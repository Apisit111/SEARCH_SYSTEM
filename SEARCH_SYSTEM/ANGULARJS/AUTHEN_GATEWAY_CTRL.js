app.controller('AUTHEN_GATEWAY_CTRL', function ($scope, $http, $location, $timeout, SERVICE_CENTER) {
    $scope.SET_MAIN_PAGE = "";
    $scope.SET_MAIN_POPUP_PAGE = "";
    $scope.CHK_PAGE = 'false';
    $scope.PROCESS_ID = '';
    $scope.LCTLCNNO = '';
    $scope.LOADING = false;
    $scope.loadarray = [];
    $scope.reload = 0;
    $scope.LIST_PROJECT = "";

    //function QueryString(name) {//รับพารามิเตอร์จาก Query string
    //    var regexS = "[\\?&]" + name + "=([^&#]*)",
    //        regex = new RegExp(regexS),
    //        results = regex.exec(window.location.search);
    //    if (results === null) {
    //        return "";
    //    } else {
    //        return decodeURIComponent(results[1].replace(/\+/g, " "));
    //    }
    //}

    var host = '';
    if ($location.host() === 'localhost') {
        host = $location.protocol() + '://' + $location.host() + ':' + $location.port() + '/';
    } else {
        host = $location.protocol() + '://' + $location.host() + '/FDA_FOOD_LOCATION_MVC/';
    }


    page_load();

    function page_load() {
        //runQuery2(); //ยังไม่ได้ใช้
        $scope.SET_MAIN_PAGE = host + "Home/Index";
        //GET_SET_FULL_MODEL();
        //$scope.SET_MAIN_PAGE = "/FOOD_CUS/FRM_MAIN_SELECT_LOCATION";
        //$scope.SET_MAIN_PAGE = 
    }

    //function runQuery2() { //รับพารามิเตอร์จาก Query string
    //    //$scope.IDA = QueryString("IDA");
    //    $scope.PROCESS_ID = QueryString("PROCESS_ID");
    //    $scope.token = QueryString("Token");
    //    //$scope.token = "xhEvHP7fiTxFiqG8niawhwUU";
    //}

    function GET_SET_FULL_MODEL() {
        if ($scope.FULL_MODEL === undefined) {
            var getData = SERVICE_CENTER.GET_SET_FULL_MODEL(); //เรียก function GET_SET_FULL_MODEL ที่ไฟล์ SERVICE_CENTER.js
            getData.then(function (datas) {
                $scope.FULL_MODEL = datas.data;
                var getData = SERVICE_CENTER.GET_DATA_LOCATION($scope.FULL_MODEL);


                getData.then(function (datas) {
                    $scope.DATA_LOCATION = datas.data;

                }, function () {
                    alert(error_message);
                });

                var getData_cer = SERVICE_CENTER.GET_DATA_LOCATION_CER($scope.FULL_MODEL);
                getData_cer.then(function (datas) {
                    $scope.DATA_LOCATION_CER = datas.data;

                }, function () {
                    alert(error_message);
                });



            }, function () {
                alert(error_message);
            });
        }

    }

    ////ข้อสำคัญ ที่ต้องระวังมากๆ ตัวเล็กใหญ่มีผลมากๆ

    ////function ปุ่มเมนูด้านบน (ดูวิธีเรียกที่หน้า AUTHEN_GATEWAY.vbhtml ng-click="BTN_MENU_CLICK(datas.PAGE_PATH,datas.PAGE_NAME,datas.IDA,datas.PROCESS_ID)")
    $scope.BTN_MENU_CLICK = function (path, path_name, IDA, PROCESS_ID) {
        //$scope.SET_MAIN_PAGE = path;
        if (path_name === 'Profile' || path_name === 'Performance' || path_name === 'Dashboard') {
            $scope.SET_MAIN_PAGE = path;
            $scope.SET_SUB_MAIN_PAGE = '';
        }
        else {

            $scope.FULL_MODEL.FK_IDA = IDA;
            $scope.FULL_MODEL.PROCESS_ID = PROCESS_ID;
            $scope.FULL_MODEL.PROCESS_NAME = path_name;
            var getData = Object;
            getData = SERVICE_CENTER.bind_data_sub_menu($scope.FULL_MODEL);
            getData.then(function (datas) {
                $scope.FULL_MODEL = datas.data;
            }, function () {
                alert(error_message);
            });
            $scope.SET_MAIN_PAGE = path;
            $scope.SET_SUB_MAIN_PAGE = '';
        }

        $scope.MAIN_PAGE_IDA = IDA;
        $scope.PROCESS_ID = PROCESS_ID;
    }



    //function ปุ่มเมนูด้านข้าง (ดูวิธีเรียกที่หน้า menu_left.vbhtml ng-click="BTN_SUB_MENU_CLICK(datas.PAGE_PATH , datas.PAGE_NAME , datas.PROCESS_ID , datas.OBJECT_TYPE , $index , datas.PROCESS_NAME)")
    $scope.BTN_SUB_MENU_CLICK = function (PAGE_PATH, PROCESS_ID, PAGE_NAME, TYPE) {
        //$scope.LOADING = true;
        $scope.PageName = PAGE_NAME;
        $scope.FULL_MODEL.PROCESS_NAME = PAGE_NAME;
        $scope.SET_SUB_MAIN_PAGE = PAGE_PATH;
        $scope.FULL_MODEL.PROCESS_ID = PROCESS_ID;
        $scope.TYPE = TYPE
        //$scope.FULL_MODEL.FOOD_XML.PROCESS_ID = PROCESS_ID;
        var getData = Object;
        if (TYPE == 99) {
            getData = SERVICE_CENTER.bind_data_main_drive_staff($scope.FULL_MODEL);
        } else {
            getData = SERVICE_CENTER.bind_data_main_drive($scope.FULL_MODEL);
        }

        getData.then(function (datas) {
            $scope.SET_SUB_MAIN_PAGE = $scope.SET_SUB_MAIN_PAGE + '?reload=' + $scope.reload;
            $scope.reload += 1;
            $scope.DataMainDrive = datas.data;
            //$scope.LOADING = false;

            //if (PROCESS_ID == 8) {
            //     getData = SERVICE_CENTER.bind_data_main_drive_staff($scope.FULL_MODEL);
            //} else {
            //     getData = SERVICE_CENTER.bind_data_main_drive($scope.FULL_MODEL);

            //}

        }, function () {
            alert(error_message);
        });

    }

    $scope.selectFileforUpload = function ($files) {
        $scope.SelectedFileForUpload = $files;
        const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000
        });

        Toast.fire({
            type: 'success',
            title: 'สามารถใช้ไฟล์นี้ได้'
        });
    };

    $scope.btn_view = function () {
        $(".l-item").click(function () {
            $(".l-item").each(function () {
                $(this).removeClass("active");
            });
            $(this).addClass("active");

            $(".b-list").each(function (i, v) {
                $(this).removeClass("active");
            });
            $(".b-list." + $(this).attr("data-target")).addClass("active");
        });
        $(".adj .adj-s").click(function () {
            let mm = $(this).attr("data-mode");
            $(".adj-s").each(function () {
                $(this).removeClass("active");
            });
            $(this).addClass("active");

            $(".b-list").each(function (i, v) {
                $(this).removeClass("rrr ggg");
                $(this).addClass(mm);
            });
        });
    }





});
