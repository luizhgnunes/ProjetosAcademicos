var app = angular.module("PedidoApp", ['ui.bootstrap']);

app.controller('PedidoController', function ($scope, $http) {

    var url = window.location.href;
    var idPedido = url.substring(url.lastIndexOf('/') + 1).split('&')[0].split('=')[1];

    $scope.obterPedido = function () {
        $http({
            url: '/Pedido/ObterPedido',
            method: 'POST',
            data: { codigoDoPedido: idPedido }
        })
            .success(function (data, status, headers, config) {
                $scope.Pedido = data;
            })
            .error(function (data, status, headers, config) {
                // Lança o erro no console do navegador caso ocorra
                console.log("Erro: " + status + "\nConfig: " + JSON.stringify(config) + "\nData:\n" + data);
            });
    };
    
    $(document).ready(function () {
        $scope.obterPedido();
    });
    

});
