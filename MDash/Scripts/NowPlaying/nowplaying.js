var nowPlayingSelectedIndex = 0;
var nowPlayingInterval;

$(function () {
    $.ajax({
        url: "/api/NowPlaying"
    }).done(function (data) {
        UpdateNowPlaying(data);
    });

    $('#nowPlayingSection li a').click(function () {
        $('#nowPlayingImage').attr('src', "http://192.168.30.202:32400" + $(this).attr('data-thumb'));
        $('#nowPlayingTitle').html($(this).attr('data-name'));
    });
});

function UpdateNowPlaying(data) {
    $('#nowPlayingSection').html("");

    $.each(data.Clients, function (i, client) {       
        var clientHtml = $('<a href="#"></a>');
        clientHtml.html(client.Name);
        clientHtml.attr('data-address', client.Address);
        clientHtml.attr('onclick', 'NowPlayingSwitchClient("' + i + '");');

        var clientHtmlWrapper = $('<li></li>');
        clientHtmlWrapper.append(clientHtml);

        $('#nowPlayingSection').append(clientHtmlWrapper);
    });

    NowPlayingSwitchClient(nowPlayingSelectedIndex);
}

function NowPlayingSwitchClient(idx) {
    var selClient = $('#nowPlayingSection li a').get(idx);

    nowPlayingSelectedIndex = idx;

    // Clear the interval
    clearInterval(nowPlayingInterval);

    // When we have CSS classes in place to show the selected client update them here!

    // Call back to the server to get full now playing info. Once we get the info set the interval
    $.ajax('api/NowPlaying/' + $(selClient).attr('data-address')).done(function(data) {
        console.log(data);
    });
}