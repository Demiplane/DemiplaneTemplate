// Write your Javascript code.

$(document).ready(function () {
    $(".dropdown-item").click(function (event) {
        $("#dropdownMenuButton").text(event.target.textContent);
    });

    $('#roll-d4-button').click(function () {
        let rollerName = $('#dropdownMenuButton').text();
        $.ajax({
            url: '/Roller/RollD4',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            fadingObject.fade("d4-result", 0, 300);
            fadingObject.countDown();
            $('#d4-result').text(result);
        });
    });

    $('#roll-d6-button').click(function () {
        let rollerName = $('#dropdownMenuButton').text();
        $.ajax({
            url: '/Roller/RollD6',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            fadingObject.fade("d6-result", 0, 300);
            fadingObject.countDown();
            $('#d6-result').text(result);
        });
    });

    $('#roll-d8-button').click(function () {
        let rollerName = $('#dropdownMenuButton').text();
        $.ajax({
            url: '/Roller/RollD8',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            fadingObject.fade("d8-result", 0, 300);
            fadingObject.countDown();
            $('#d8-result').text(result);
        });
    });

    $('#roll-d10-button').click(function () {
        let rollerName = $('#dropdownMenuButton').text();
        $.ajax({
            url: '/Roller/RollD10',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            fadingObject.fade("d10-result", 0, 300);
            fadingObject.countDown();
            $('#d10-result').text(result);
        });
    });

    $('#roll-d12-button').click(function () {
        let rollerName = $('#dropdownMenuButton').text();
        $.ajax({
            url: '/Roller/RollD12',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            fadingObject.fade("d12-result", 0, 300);
            fadingObject.countDown();
            $('#d12-result').text(result);
        });
    });

    $('#roll-d20-button').click(function () {
        let rollerName = $('#dropdownMenuButton').text();
        $.ajax({
            url: '/Roller/RollD20',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            fadingObject.fade("d20-result", 0, 300);
            fadingObject.countDown();
            $('#d20-result').text(result);
        });
    });


    $('#roll-d100-button').click(function () {
        let rollerName = $('#dropdownMenuButton').text();
        $.ajax({
            url: '/Roller/RollD100',
            data: {
                RollerName: rollerName
            }
        }).done(function (result) {
            fadingObject.fade("d100-result", 0, 300);
            fadingObject.countDown();
            $('#d100-result').text(result);
        });
    });
});


var fadingObject = {
    yellowColor: function (val) {
        var r = (val*1.25).toString(16);
        var g = (val*1.25).toString(16);
        var b = (val*1.25).toString(16);
        var newval = "#" + r + g + b;
        return newval;
    },

    fade: function (id, start, finish) {
        this.count = this.start = start;
        this.finish = finish;
        this.id = id;
        this.countDown = function () {
            this.count += 30;
            if (this.count >= this.finish) {
                document.getElementById(this.id).style.background =
                    "transparent";
                this.countDown = null;
                return;
            }
            document.getElementById(this.id).style.backgroundColor =
                this.yellowColor(this.count);
            setTimeout(this.countDown.bind(this), 25);
        };
    }
};