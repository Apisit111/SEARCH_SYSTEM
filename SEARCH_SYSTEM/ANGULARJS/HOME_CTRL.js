app.controller('HOME_CTRL', function ($scope, $http, $location, SERVICE_CENTER) {
    $scope.allone = [];

    load();

    $scope.message1 = "";
    $scope.message2 = "";
    $scope.message3 = "";
    $scope.message4 = "";

    $scope.currentPage = 0; // เริ่มที่ .page 0
    $scope.itemsPerPage = '10'; // แสดงกี่อันในหน้าแก้ตรงนี้ 

    function load() {
        nnn();
        STATUS_NAME();
        REQUEST_TYPE();
        THACHNGWTNM();
        FDTYPENAME();

    }

    function setDataList() {
        var getData = SERVICE_CENTER.setData('MainDrive');
        getData.then(function (datas) {
            $scope.allone = datas.data.DATA_LIST.Data
            $scope.BK = datas.data.DATA_LIST.Data
            $scope.message1 = "1"
            console.log($scope.allone.length);
        }, function () {
            alert($scope.error_message);
        });
        var getData = SERVICE_CENTER.setData('Fregntf2020');
        getData.then(function (datas) {
            $scope.allone = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.BK = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.message2 = "2"
            console.log($scope.allone.length);
        }, function () {
            alert($scope.error_message);
        });
        var getData = SERVICE_CENTER.setData('Fregntf2019');
        getData.then(function (datas) {
            $scope.allone = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.BK = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.message3 = "3"
            console.log($scope.allone.length);
        }, function () {
            alert($scope.error_message);
        });
        var getData = SERVICE_CENTER.setData('Fregntf2018');
        getData.then(function (datas) {
            $scope.allone = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.BK = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.message4 = "4"
            console.log($scope.allone.length);
        }, function () {
            alert($scope.error_message);
        });
        var getData = SERVICE_CENTER.setData('Fregntf2017');
        getData.then(function (datas) {
            $scope.allone = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.BK = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.message4 = "4"
            console.log($scope.allone.length);
        }, function () {
            alert($scope.error_message);
        });
        var getData = SERVICE_CENTER.setData('Fregntf2016');
        getData.then(function (datas) {
            $scope.allone = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.BK = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.message4 = "4"
            console.log($scope.allone.length);
        }, function () {
            alert($scope.error_message);
        });
        var getData = SERVICE_CENTER.setData('Fregntf2015');
        getData.then(function (datas) {
            $scope.allone = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.BK = $scope.allone.concat(datas.data.DATA_LIST.Data)
            $scope.message4 = "4"
            console.log($scope.allone.length);
        }, function () {
            alert($scope.error_message);
        });
        return new Promise(function (resolve) {
            resolve($scope.allone);
        })
        //await PAGE_LOAD()
        //await PAGE_LOAD1()
        //await PAGE_LOAD2()
        //await PAGE_LOAD3()
    }
    function PAGE_LOAD() {

    }

    function PAGE_LOAD1() {

    }

    function PAGE_LOAD2() {

    }

    function PAGE_LOAD3() {

    }

    function REQUEST_TYPE() {
        var getData = SERVICE_CENTER.REQUEST_TYPE();
        getData.then(function (datas) {

            $scope.request_type = datas.data;

        });

    }

    function THACHNGWTNM() {
        var getData = SERVICE_CENTER.THACHNGWTNM();
        getData.then(function (datas) {

            $scope.thachngwtnm = datas.data;

        });

    }

    function FDTYPENAME() {
        var getData = SERVICE_CENTER.FDTYPENAME();
        getData.then(function (datas) {

            $scope.fdtypename = datas.data;

        });

    }

    function STATUS_NAME() {
        var getData = SERVICE_CENTER.STATUS_NAME();
        getData.then(function (datas) {

            $scope.statusname = datas.data;

        });

    }


    function myfunction(input) {
        if (input !== undefined) {
            if (input == null) { return ""; }
            var bYears = 543;
            //You will have to write formula for getting the days down to milliseconds

            // Convert 'days' to milliseconds
            var millies = (1000 * 60 * 60 * 24 * 365 * bYears);
            var d = new Date(input).getTime() + millies;
            var _date = (new Date(d), 'dd/MM/yyyy');

            return _date;
        }
    }


    //$scope.IsVisible = false;
    $scope.refesh_search = function (DATA) {
        $scope.allone = [];
        $scope.allone = $scope.allone.concat($scope.BK);
        if ($scope.x.RECEIVING_NUM != "" && $scope.x.RECEIVING_NUM != undefined) {//เลขรับ
            $scope.allone = $scope.allone.filter(function (d) {
                return d.RECEIVING_NUM.indexOf($scope.x.RECEIVING_NUM) != -1
            });
        }

        if ($scope.x.DIRECTORY_NUM != "" && $scope.x.DIRECTORY_NUM != undefined) {//เลขสารบบ
            $scope.allone = $scope.allone.filter(function (d) {
                return d.DIRECTORY_NUM.indexOf($scope.x.DIRECTORY_NUM) != -1
            });
        }

        if ($scope.x.LICENSE_NUM != "" && $scope.x.LICENSE_NUM != undefined) {//เลขที่ใบอนุญาต
            $scope.allone = $scope.allone.filter(function (d) {
                return d.LICENSE_NUM.indexOf($scope.x.LICENSE_NUM) != -1
            });
        }

        if ($scope.x.PRODUCT_NAME != "" && $scope.x.PRODUCT_NAME != undefined) {//ชื่อผลิตภัณฑ์
            $scope.allone = $scope.allone.filter(function (d) {
                return d.PRODUCT_NAME.indexOf($scope.x.PRODUCT_NAME) != -1
            });
        }

        if ($scope.x.PLACE_NAME != "" && $scope.x.PLACE_NAME != undefined) {//ชื่อสถานที่
            $scope.allone = $scope.allone.filter(function (d) {
                return d.PLACE_NAME.indexOf($scope.x.PLACE_NAME) != -1
            });
        }



        if ($scope.x.RCVDATE != "" && $scope.x.RCVDATE != undefined) {//วันที่รับ
            $scope.allone = $scope.allone.filter(function (d, e) {
                if ($scope.x.RCVDATE_TO != "" && $scope.x.RCVDATE_TO != undefined) {
                    return dateCheck($scope.x.RCVDATE, $scope.x.RCVDATE_TO, d.RCVDATE.substring(0, d.RCVDATE.indexOf(" ")))
                } else {
                    return d.RCVDATE.substring(0, d.RCVDATE.indexOf(" ")).indexOf($scope.x.RCVDATE) != -1
                }
            });
        }
        if ($scope.x.APPDATE != "" && $scope.x.APPDATE != undefined) {//วันที่สิ้นสุด
            $scope.allone = $scope.allone.filter(function (d) {
                if ($scope.x.APPDATE_TO != "" && $scope.x.APPDATE_TO != undefined) {
                    return dateCheck($scope.x.APPDATE, $scope.x.APPDATE_TO, d.APPDATE.substring(0, d.APPDATE.indexOf(" ")))
                } else {
                    console.log($scope.x.APPDATE);
                    console.log(d.APPDATE.substring(0, d.APPDATE.indexOf(" ")));
                    return d.APPDATE.substring(0, d.APPDATE.indexOf(" ")).indexOf($scope.x.APPDATE) != -1
                }
            });
        }




        if ($scope.x.STATUS_NAME != "" && $scope.x.STATUS_NAME != undefined) {//สถานะ
            $scope.allone = $scope.allone.filter(function (d) {
                return d.STATUS_NAME === $scope.x.STATUS_NAME;
            });
        }

        if ($scope.x.THACHNGWTNM != "" && $scope.x.THACHNGWTNM != undefined) {//จังหวัด
            $scope.allone = $scope.allone.filter(function (d) {
                return d.PVNCD === $scope.x.THACHNGWTNM;
            });
        }

        if ($scope.x.TYPEREQUEST != "" && $scope.x.TYPEREQUEST != undefined) {//ประเภทคำขอ
            $scope.allone = $scope.allone.filter(function (d) {
                return d.REQUEST_TYPE === $scope.x.TYPEREQUEST;
            });
        }

        if ($scope.x.FDTYPENAME != "" && $scope.x.FDTYPENAME != undefined) {//ประเภทอาหาร
            $scope.allone = $scope.allone.filter(function (d) {
                return d.FDTYPECD === $scope.x.FDTYPENAME;
            });
        }


        //form.submit();







    }

    function dateCheck(from, to, check) {

        var fDate, lDate, cDate;
        fDate = Date.parse(from);
        lDate = Date.parse(to);
        cDate = Date.parse(check);

        if ((cDate <= lDate && cDate >= fDate)) {
            return true;
        }
        return false;
    }
    async function nnn() {
        await setDataList();
        await setPage();

    }

    function setPage() {
        $scope.currentPage = 1;
        $scope.totalItems = $scope.allone.length;
        $scope.entryLimit = 10; // items per page
        $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
        $scope.numrow = $scope.allone.count;
        console.log($scope.allone.length);
    }

    $scope.BTN_EXPORT_EXCEL = function (item) {

        JSONToCSVConvertor($scope.allone, "รายการผลการค้นหาสารส่วนประกอบอาหารทั่วไป", true);
    }

    function JSONToCSVConvertor(JSONData, ReportTitle, ShowLabel) {

        //If JSONData is not an object then JSON.parse will parse the JSON string in an Object
        var arrData = typeof JSONData != 'object' ? JSON.parse(JSONData) : JSONData;
        console.log(arrData);
        var CSV = '';
        //Set Report title in first row or line

        CSV += ReportTitle + '\r\n\n';

        //This condition will generate the Label/Header
        if (ShowLabel) {
            var row = "";

            //This loop will extract the label from 1st index of on array
            for (var index in arrData[0]) {

                //Now convert each value to string and comma-seprated
                if (index != '$$hashKey') {
                    row += index + ',';
                }

            }

            row = row.slice(0, -1);

            //append Label row with line break
            CSV += row + '\r\n';
        }

        //1st loop is to extract each row
        for (var i = 0; i < arrData.length; i++) {
            var row = "";

            //2nd loop will extract each column and convert it in string comma-seprated
            for (var index in arrData[i]) {
                if (index != '$$hashKey') {
                    row += '"' + arrData[i][index] + '",';
                }
            }

            row.slice(0, row.length - 1);

            //add a line break after each row
            CSV += row + '\r\n';
        }

        if (CSV == '') {
            alert("Invalid data");
            return;
        }

        //Generate a file name
        var fileName = "ผลการค้นหา";
        //this will remove the blank-spaces from the title and replace it with an underscore
        fileName += ReportTitle.replace(/ /g, "_");
        var universalBOM = "\uFEFF";
        //Initialize file format you want csv or xls
        //var uri = 'data:text/csv;charset=UTF-8,' + encodeURIComponent(universalBOM + CSV);
        var uri = 'data:application/vnd.ms-excel;charset=UTF-8,' + encodeURIComponent(universalBOM + CSV);


        // Now the little tricky part.
        // you can use either>> window.open(uri);
        // but this will not work in some browsers
        // or you will not get the correct file extension    

        //this trick will generate a temp <a /> tag
        var link = document.createElement("a");
        link.href = uri;

        //set the visibility hidden so it will not effect on your web-layout
        link.style = "visibility:hidden";
        link.download = fileName + ".xls";

        //this part will append the anchor tag and remove it after automatic click
        document.body.appendChild(link);
        link.click();
        document.body.removeChild(link);
        $scope.LOADING = false;
        Swal.fire('ดาวน์โหลดสำเร็จ', '', 'success');
    }



    //function set_cal(ele)//function สร้างตัวเลือกปฎิทิน
    //{
    //    $(ele).datepicker({
    //        onSelect: (date_text) => {
    //            let arr = date_text.split("/");
    //            let new_date = arr[0] + "/" + arr[1] + "/" + (parseInt(arr[2]) + 543).toString();
    //            $(ele).val(new_date);
    //            $(ele).css("color", "");
    //        },
    //        beforeShow: () => {

    //            if ($(ele).val() != "") {
    //                let arr = $(ele).val().split("/");
    //                let new_date = arr[0] + "/" + arr[1] + "/" + (parseInt(arr[2]) - 543).toString();
    //                $(ele).val(new_date);

    //            }

    //            $(ele).css("color", "white");
    //        },
    //        onClose: () => {

    //            $(ele).css("color", "");

    //            if ($(ele).val() != "") {

    //                let arr = $(ele).val().split("/");
    //                if (parseInt(arr[2]) < 2500) {
    //                    let new_date = arr[0] + "/" + arr[1] + "/" + (parseInt(arr[2]) + 543).toString();
    //                    $(ele).val(new_date);
    //                }
    //            }


    //        },
    //        dateFormat: "dd/mm/yy", //กำหนดรูปแบบวันที่เป็น วัน/เดือน/ปี
    //        changeMonth: true,//กำหนดให้เลือกเดือนได้
    //        changeYear: true,//กำหนดให้เลือกปีได้
    //        showOtherMonths: true,//กำหนดให้แสดงวันของเดือนก่อนหน้าได้
    //    });



    //}

    //$(document).ready(function () {
    //    //เรียก function set_cal เมื่อเปิดหน้าเว็บ โดยส่ง object element ที่มี id เป็น datepicker เป็นพารามิเตอร์
    //    set_cal($("#datepicker"));

    //})

});