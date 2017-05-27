var app = angular.module("RoteiroMotoristaApp", ['ui.bootstrap']);

app.controller('RoteiroMotoristaController', function ($scope, $http) {

    /*
    $scope.logar = function () {
        $http({
            url: '/Usuario/Logar',
            method: 'POST',
            data: { Usuario: $scope.Usuario }
        })
            .success(function (data, status, headers, config) {
                if (data == "True") {
                    window.location.href = "/User/";
                } else {
                    alert("Usuário ou senha inválidos.");
                }
            })
            .error(function (data, status, headers, config) {
                // Lança o erro no console do navegador caso ocorra
                console.log("Erro: " + status + "\nConfig: " + JSON.stringify(config) + "\nData:\n" + data);
            });
    };
    */
});

