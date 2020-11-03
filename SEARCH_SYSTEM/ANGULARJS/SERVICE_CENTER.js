app.service("SERVICE_CENTER", function ($http, $location) {

    var host = '';
    if ($location.host() === 'localhost') {
        host = $location.protocol() + '://' + $location.host() + ':' + $location.port() + '/';
    } else {
        host = $location.protocol() + '://' + $location.host() + '/FDA_FOOD_LOCATION_MVC/';
    }

    this.GET_SET_FULL_MODEL = function (TOKEN) { //เรียก Full model
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/SET_FULL_MODEL", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            params: {
                TOKEN: TOKEN
            }
        });
        return response;

    };

    this.GET_DATA_LOCATION = function (model) {
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/GET_DATA_LOCATION", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            params: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };

    this.GET_DATA_LOCATION_CER = function (model) {
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/GET_DATA_LOCATION_CER", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            params: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };



    this.bind_data_sub_menu = function (model) {
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/bind_data_sub_menu", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            params: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };


    this.bind_data_main_drive = function (model) {
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/bind_data_main_drive", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            params: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };



    this.bind_data_main_drive_staff = function (model) {
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/bind_data_main_drive_staff", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            params: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };




    this.PDF_DOWNLOAD = function (model) { //ส่ง Full model
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/PDF_DOWNLOAD",
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };

    this.OUTPUT_DOWNLOAD = function (model) { //ส่ง Full model
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/PDF_OUTPUT_DOWNLOAD",
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };

    this.upload_pdf = function (model, file) { //เรียก Full model

        var response = Upload.upload({
            // url: host + "FOOD_CUST/UPLOAD_PDF",
            url: host + "DATA_CENTER/UPLOAD_PDF",
            data: {
                MODEL: JSON.stringify(model),
                files: file
            }
        });
        return response;
    };

    this.GET_DATA_XML = function (model) {
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/GET_DATA_XML", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };

    this.UPDATE_STATUS = function (model) {
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/UPDATE_STATUS", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };

    this.MASTER_STATUS_STAFF = function (model) {
        var response = $http({
            method: "post",
            url: host + "DATA_CENTER/MASTER_STATUS_STAFF", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };



    this.GET_DATA_CHANGWAT = function () {
        var response = $http({
            method: "post",
            url: "CONFIG/SP_GET_MAS_syschngwt",
            dataType: "json"
        });
        return response;
    };

    this.GET_DATA_AMPHER = function (pvncd) {
        var response = $http({
            method: "post",
            url: "CONFIG/SP_GET_MAS_sysampher",
            dataType: "json",
            data: {
                pvncd
            }
        });
        return response;
    };

    this.GET_DATA_THAMBL = function (pvncd, ampher) {
        var response = $http({
            method: "post",
            url: "CONFIG/SP_GET_MAS_systhmbl",
            dataType: "json",
            data: {
                pvncd,
                ampher
            }
        });
        return response;
    };


    this.GET_DATA_FDTYPE = function () {
        var response = $http({
            method: "post",
            url: "CONFIG/SP_GET_SHOW_FOOD_FDTYPE",
            dataType: "json"
        });
        return response;
    };

    this.GET_DATA_METHOD_BY_FDTYPE = function (type, subp) {
        var response = $http({
            method: "post",
            url: "CONFIG/SP_GET_SHOW_FOOD_METHOD_BY_FDTYPE",
            dataType: "json",
            data: {
                type,
                subp
            }

        });
        return response;
    };


    this.GATEWAY_MAIN = function (model) {
        var response = $http({
            method: "post",
            url: host + "FOOD_STAFF/GATEWAY_MAIN", //ไปดูที่ไฟล์ FOOD_STAFFController.vb
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };

    this.REFESH_SEARCH = function (DATA) { //เรียก Full model
        var response = $http({
            method: "post",
            url: "../HOME/CONNECT_VB", //ไปดูที่ไฟล์ DATA_CENTERController.vb
            dataType: "json",
            data: {
                DATA: DATA

            }
        });
        return response;
     };

    this.PAGE_LOAD = function () {
        return $http.get("../Home/PAGE_LOAD");
    }

    this.PAGE_LOAD1 = function () {
        return $http.get("../Home/PAGE_LOAD1");
    }

    this.PAGE_LOAD2 = function () {
        return $http.get("../Home/PAGE_LOAD2");
    }

    this.PAGE_LOAD3 = function () {
        return $http.get("../Home/PAGE_LOAD3");
    }

    this.STATUS_NAME = function () {
        return $http.get("../Home/STATUS_NAME");
    }

    this.REQUEST_TYPE = function () {
        return $http.get("../Home/REQUEST_TYPE");
    }

    this.FDTYPENAME = function () {
        return $http.get("../Home/FDTYPENAME");
    }

    this.THACHNGWTNM = function () {
        return $http.get("../Home/THACHNGWTNM");
    }


});
