(function () {

   angular.module('app').controller('storeController',
      ['$q', '$scope', '$timeout', 'dataservice', 'logger', controller]);

   function controller($q, $scope, $timeout, dataservice, logger) {


      $scope.products = [
         {
            nome: 'teer',
            preco:34343
         },
         {
            nome: 'eeee',
            preco: 33
         }
      ];

      getProducts();

      function getProducts() {
         $timeout(getProductsImpl, 0);

         function getProductsImpl() {
            dataservice.getProducts(false)
               .then(querySucceeded);
         }

         function querySucceeded(data) {
            console.log(data);
         }
      };
   }
})();