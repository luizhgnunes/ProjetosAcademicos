var app = angular.module("UsuarioCadastrarApp", ['ui.bootstrap']);

app.controller('UsuarioCadastrarController', function ($scope, $http) {

    $scope.submited = false;

    $scope.enviado = false;

    $scope.submitForm = function () {

        if ($scope.myForm.$valid) {
            // Formulário validado
            $scope.enviado = true;
        }

    };

    $scope.checkFields = function () {
        $scope.submited = true;
    };

    function validate(usuarioObj) {
        /*
        if (!angular.isUndefined(usuarioObj)) {
            if (!('Nome' in usuarioObj) || ((usuarioObj.Nome).trim() == '')) {
                alert(JSON.stringify("Nome vazio"));
            }
        } else {
            alert('Todos os campos vazios');
        }
        */
    }

    // Evento de Click do botão
    $("#button-cadastrar").click(function () {
        validate($scope.Usuario);
    }); // Evento de click do botão

});

