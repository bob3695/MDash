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
        clientHtml.attr('onclick', 'NowPlayingSwitchClient("' + client.Address + '");');

        var clientHtmlWrapper = $('<li></li>');
        clientHtmlWrapper.append(clientHtml);

        $('#nowPlayingSection').append(clientHtmlWrapper);
    });
}

function NowPlayingSwitchClient(address) {
    console.log(address);
}