// Write your Javascript code.


$(document).ready(function () {
    $(".btn-group > .btn").click(function () {
        $(this).addClass("active").siblings().removeClass("active");
    });

    $('#roll-d4-button').click(function () {
        let rollerName = $('#roller-button-group').text();
        $.ajax({
            url: '/Roller/RollD4',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            $('#d4-result').text(result);
        });
    });

    $('#roll-d6-button').click(function () {
        $.ajax({
            url: '/Roller/RollD6',
            data: {
                RollerName: 'Standard'
            }
        }).done(function (result) {
            $('#d6-result').text(result);
        });
    });

    $('#roll-d8-button').click(function () {
        $.ajax({
            url: '/Roller/RollD8',
            data: {
                RollerName: 'Standard'
            }
        }).done(function (result) {
            $('#d8-result').text(result);
        });
    });

    $('#roll-d10-button').click(function () {
        $.ajax({
            url: '/Roller/RollD10',
            data: {
                RollerName: 'Standard'
            }
        }).done(function (result) {
            $('#d10-result').text(result);
        });
    });

    $('#roll-d12-button').click(function () {
        $.ajax({
            url: '/Roller/RollD12',
            data: {
                RollerName: 'Standard'
            }
        }).done(function (result) {
            $('#d12-result').text(result);
        });
    });

    $('#roll-d20-button').click(function () {
        let rollerName = $('dropdown-item active').text() || 'Standard';
        $.ajax({
            url: '/Roller/RollD20',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            $('#d20-result').text(result);
        });
    });


    $('#roll-d100-button').click(function () {
        $.ajax({
            url: '/Roller/RollD100',
            data: {
                RollerName: 'Standard'
            }
        }).done(function (result) {
            $('#d100-result').text(result);
        });
    });
});
