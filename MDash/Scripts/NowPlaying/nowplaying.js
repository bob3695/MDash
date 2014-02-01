$(function () {
    console.log('here');
    $('#nowPlayingSection li a').click(function () {
        console.log('here');
        console.log(this);
        console.log($(this).attr("data-thumb"));

        $('#nowPlayingImage').attr('src', "http://192.168.30.202:32400" + $(this).attr('data-thumb'));
        $('#nowPlayingTitle').html($(this).attr('data-name'));
    });
});