var app = angular.module('SEARCH_SESTEM', ['ngMaterial', 'ngFileUpload', 'ui.bootstrap']);
app.controller('MASTER_CTRL', function ($scope, $http, $location, SERVICE_CENTER) {

    //$scope.open_list = function (PROCESS_CODE, FUNC_CODE) {
    //    Get_DATA(PROCESS_CODE, FUNC_CODE);
    //};

    //function GET_SET_FULL_MODEL(PROCESS_CODE, FUNC_CODE) {
    //    if ($scope.FULL_MODEL === undefined) {
    //        var getData = SERVICE_CENTER.GET_SET_FULL_MODEL($scope.FULL_MODEL);
    //        getData.then(function (datas) {
    //            $scope.FULL_MODEL = datas.data;
    //        }, function () {
    //            alert($scope.error_message);
    //        });
    //    }
    //    else {

    //        Get_DATA(PROCESS_CODE, FUNC_CODE);
    //    }
    //}

    //function Get_DATA(PROCESS_CODE, FUNC_CODE) {
    //    $scope.FULL_MODEL.PROCESS_CODE = PROCESS_CODE;
    //    $scope.FULL_MODEL.FUNC_CODE = FUNC_CODE;
    //    var getData = SERVICE_CENTER.GET_SET_FULL_MODEL($scope.FULL_MODEL);
    //    getData.then(function (datas) {
    //        $scope.FULL_MODEL = datas.data;
    //    }, function () {
    //        alert($scope.error_message);
    //    });

    //}

});

angular.module('SEARCH_SESTEM').config(function ($mdDateLocaleProvider) {
    $mdDateLocaleProvider.formatDate = function (date) {
        return moment(date).format("DD/MM/YYYY");
    };
});

app.directive('loading', ['$http', function ($http) {
    return {
        restrict: 'A',
        link: function (scope, elm, attrs) {
            scope.isLoading = function () {
                return $http.pendingRequests.length > 0;
            };

            scope.$watch(scope.isLoading, function (v) {
                if (v) {
                    elm.show();
                } else {
                    elm.hide();
                }
            });
        }
    };

}]);

app.filter('bdate', function ($filter) {
    try {
        return function (input) {
            if (input !== undefined) {
                if (input == null) { return ""; }
                var bYears = 543;
                //You will have to write formula for getting the days down to milliseconds

                // Convert 'days' to milliseconds
                var millies = 1000 * 60 * 60 * 24 * 365 * bYears;
                var d = new Date(input).getTime() + millies
                var _date = $filter('date')(new Date(d), 'dd/MM/yyyy');
                //console.log(_date);
                return _date
            }
        };
    } catch (e) {

    }

});

app.filter('willdev', function () {
    return function (data) {
        return new Date(parseInt(data.replace('/Date(', '').replace(')/', ''))).toLocaleDateString('th-th');
    };
});

app.config(function ($mdDateLocaleProvider) {
    var shortMonths = ['ม.ค.', 'ก.พ.', 'มี.ค.', 'เม.ย.', 'พ.ค.', 'มิ.ย.', 'ก.ค.', 'ส.ค.', 'ก.ย.', 'ต.ค.', 'พ.ย.', 'ธ.ค.'];
    $mdDateLocaleProvider.months = ['มกราคม', 'กุมภาพันธ์', 'มีนาคม', 'เมษายน', 'พฤษภาคม', 'มิถุนายน', 'กรกฎาคม', 'สิงหาคม', 'กันยายน', 'ตุลาคม', 'พฤศจิกายน', 'ธันวาคม'];
    $mdDateLocaleProvider.shortMonths = shortMonths;
    $mdDateLocaleProvider.days = ['อาทิตย์', 'จันทร์', 'อังคาร', 'พุธ', 'พฤหัสบดี', 'ศุกร์', 'เสาร์'];
    $mdDateLocaleProvider.shortDays = ['อา', 'จ', 'อ', 'พ', 'พฤ', 'ศ', 'ส'];
    $mdDateLocaleProvider.monthHeaderFormatter = function (date) {
        return shortMonths[date.getMonth()] + ' ' + (date.getFullYear() + 543);
    };
    $mdDateLocaleProvider.formatDate = function (date) {
        return `${moment(date).format('DD/MM')}/${moment(date).get('year') + 543}`;
    };
    $mdDateLocaleProvider.parseDate = function (dateString) {
        var dateArray = dateString.split("/");
        dateString = dateArray[1] + "/" + dateArray[0] + "/" + (dateArray[2] - 543);
        var m = moment(dateString, 'L', true);
        return m.isValid() ? m.toDate() : new Date(NaN);
    };
})