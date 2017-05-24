app.directive("drtNumerico", function () {
    return {
        restrict: 'A',
        link: function ($scope, $element, $attrs) {
            $element.bind('keypress', function (e) {
                //e.which; e.keyCode;
                if (isNaN(String.fromCharCode(e.charCode)))
                    return false;
            });
        }
    }
});

// só aceita número e apenas uma vírgula
app.directive("drtMoedaPtBr", function () {
    return {
        restrict: 'A',
        link: function ($scope, $element, $attrs) {
            $element.bind('keypress', function (e) {
                //e.which; e.keyCode;
                if (isNaN(String.fromCharCode(e.charCode)) && e.charCode != 44 || (e.charCode == 44 && $element.val().indexOf(',') >= 0))
                    return false;
            });
        }
    }
});