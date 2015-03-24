//create angularjs controller
var app = angular.module('app', []);//set and get the angular module
app.controller('shopperController', ['$scope', '$http', shopperController]);

//angularjs controller method
function shopperController($scope, $http) {

    //declare variable for mainain ajax load and entry or edit mode
    $scope.loading = true;
    $scope.addMode = false;

    //get all shopper information
    $http.get('/api/shopper/').success(function (data) {
        $scope.shoppers = data;
        $scope.loading = false;
    })
    .error(function () {
        $scope.error = "An Error has occured while loading posts!";
        $scope.loading = false;
    });

    //by pressing toggleEdit button ng-click in html, this method will be hit
    $scope.toggleEdit = function () {
        this.shopper.editMode = !this.shopper.editMode;
    };

    //by pressing toggleAdd button ng-click in html, this method will be hit
    $scope.toggleAdd = function () {
        $scope.addMode = !$scope.addMode;
    };

    //Inser shopper
    $scope.add = function () {
        $scope.loading = true;
        $http.post('/api/shopper/', this.newshopper).success(function (data) {
            alert("Added Successfully!!");
            $scope.addMode = false;
            $scope.shoppers.push(data);
            $scope.loading = false;
        }).error(function (data) {
            $scope.error = "An Error has occured while Adding shopper! " + data;
            $scope.loading = false;
        });
    };

    //Edit shopper
    $scope.save = function () {
        alert("Edit");
        $scope.loading = true;
        var frien = this.shopper;
        alert(frien);
        $http.put('/api/shopper/' + frien.Id, frien).success(function (data) {
            alert("Saved Successfully!!");
            frien.editMode = false;
            $scope.loading = false;
        }).error(function (data) {
            $scope.error = "An Error has occured while Saving shopper! " + data;
            $scope.loading = false;
        });
    };

    //Delete shopper
    $scope.deleteshopper = function () {
        $scope.loading = true;
        var Id = this.shopper.Id;
        $http.delete('/api/shopper/' + Id).success(function (data) {
            alert("Deleted Successfully!!");
            $.each($scope.shoppers, function (i) {
                if ($scope.shoppers[i].Id === Id) {
                    $scope.shoppers.splice(i, 1);
                    return false;
                }
            });
            $scope.loading = false;
        }).error(function (data) {
            $scope.error = "An Error has occured while Saving shopper! " + data;
            $scope.loading = false;
        });
    };

}