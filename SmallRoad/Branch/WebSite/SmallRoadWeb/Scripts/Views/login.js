var app = angular.module("LoginApp", ['ui.bootstrap']);

app.controller('LoginController', function ($scope, $http) {

    $scope.logar = function () {
        $http({
            url: '/Login/Logar',
            method: 'POST',
            data: { Usuario: $scope.Usuario }
        })
            .success(function (data, status, headers, config) {
                if (data == "") {
                    alert("Usuário ou senha inválidos");
                } else {
                    window.location = "/Roteiro/";
                }
            })
            .error(function (data, status, headers, config) {
                // Lança o erro no console do navegador caso ocorra
                console.log("Erro: " + status + "\nConfig: " + JSON.stringify(config) + "\nData:\n" + data);
            });
    };

});

