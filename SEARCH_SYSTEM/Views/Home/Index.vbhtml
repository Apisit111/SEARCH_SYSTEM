
<style>

    table {
        width: 100%;
        height: 5%;
    }

    table, th, td {
        border-collapse: collapse;
    }

    th {
        padding: 10px;
        text-align: left;
    }


    td {
        text-align: left;
    }

    #t01 tr:nth-child(even) {
        background-color: #eee;
    }

    #t01 tr:nth-child(odd) {
        background-color: #fff;
    }

    #t01 th {
        background-color: #649173;
        color: white;
    }

    #example1 {
        border: 2px solid #656565;
        padding: 10px;
        border-radius: 10px;
        color: white;
    }

    #example2 {
        border: 2px solid #c2efe8;
        padding: 10px;
        border-radius: 10px;
    }
</style>

<form name="form" ng-app="SEARCH_SESTEM" ng-controller="HOME_CTRL">

    <div class="container-fluid">
        <div class="row">
            <div class="col-xs-6">
                <label>
                    <font size="7">ค้นหารายการคำขอผลิตภัณฑ์</font>
                </label>
            </div>
            <div class="col-xs"></div>
        </div>

        <div class="row">
            <div class="col-sm-auto">
                <label>
                    <font size="6">เลขรับคำขอ :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <input class="form-control input-lg" type="text" name="text2" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.RECEIVING_NUM" /><br>

            </div>
            <div class="col-sm-auto">
                <label>
                    <font size="6">เลขสารบบ :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <input class="form-control input-lg" type="text" name="text1" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.DIRECTORY_NUM" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-auto">
                <label>
                    <font size="6">เลขที่ใบอนุญาต :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <input class="form-control input-lg" type="text" name="text5" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.LICENSE_NUM" />
            </div>

            <div class="col-sm-auto">
                <label>
                    <font size="6">ชื่อผลิตภัณฑ์(THAI/ENG) :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <input class="form-control input-lg" type="text" name="text6" style="background: #e6e6e6;border-radius: 7px;" size="30" ng-model="x.PRODUCT_NAME" /><br>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-auto">
                <label>
                    <font size="6">ชื่อสถานที่ :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <input class="form-control input-lg" type="text" name="text3" style="background: #e6e6e6;border-radius: 7px;" size="40" ng-model="x.PLACE_NAME" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-auto">
                <label>
                    <font size="6">สถานะคำขอ : &nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <select class="form-control input-lg" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.STATUS_NAME"><option ng-repeat=" s in statusname">{{s.STATUSNAME}}</option></select>
            </div>
            <div class="col-sm-auto">
                <label>
                    <font size="6">จังหวัด :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <select class="form-control input-lg" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.THACHNGWTNM"><option ng-repeat=" d in thachngwtnm">{{d.thachngwtnm}}</option></select>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-auto">
                <label>
                    <font size="6">ประเภทคำขอ :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <select class="form-control input-lg" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.TYPEREQUEST"><option ng-repeat=" f in request_type">{{f.TYPEREQUEST}}</option></select><br>
            </div>
            <div class="col-sm-auto">
                <label>
                    <font size="6">วันที่รับ :&nbsp;</font>
                </label>
            </div>
            <div class="flex-gt">
                @*<input class="form-control input-lg datepicker" data-date-language="th" data-provide="datepicker" data-date-format="dd/mm/yyyy" type="text" min="" max="" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.RCVDATE" />*@
                <md-datepicker ng-model="x.RCVDATE" md-placeholder="Enter date" md-open-on-focus=""></md-datepicker>
            </div>
            <div class="col-sm-auto">
                <label>
                    <font size="6">ถึงวันที่รับ :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <input class="form-control input-lg" data-date-language="th" data-provide="datepicker" data-date-format="dd/mm/yyyy" type="text" min="" max="" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.RCVDATE_TO" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-auto">
                <label>
                    <font size="6">ประเภทอาหาร :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <select class="form-control input-lg" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.FDTYPENAME"><option ng-repeat=" g in fdtypename">{{g.fdtypename}}</option></select><br>
            </div>
            <div class="col-sm-auto">
                <label>
                    <font size="6">วันที่อนุมัติ :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <input class="form-control input-lg" data-date-language="th" data-provide="datepicker" data-date-format="dd/mm/yyyy" type="text" min="" max="" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.APPDATE" />
            </div>
            <div class="col-sm-auto">
                <label>
                    <font size="6">ถึงวันที่อนุมัติ :&nbsp;</font>
                </label>
            </div>
            <div class="col-sm">
                <input class="form-control input-lg" data-date-language="th" data-provide="datepicker" data-date-format="dd/mm/yyyy" type="text" min="" max="" style="background: #e6e6e6;border-radius: 7px;" ng-model="x.APPDATE_TO" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-10">
            </div>
            <div class="col-sm-1" align="right">
                <input id="example1" type="button" name="ค้นหา" value="ค้นหา" style="background-color: #656565;" ng-click="refesh_search(x)" />
            </div>
            <div class="col-sm" border-radius: 25px;>
                <input id="example2" type="button" name="EXCEL" value="EXCEL" style="background-color: #c2efe8;" ng-click="BTN_EXPORT_EXCEL()">
            </div>
        </div>

        @*<div ng-show="IsVisible" class="col-sm">*@
        <div class="col-sm">
            <table id="t01" frame="none" style="width:100%">
                <thead>
                    <tr>
                        <th style="width:4%">เลขรับ</th>
                        <th style="width:4%">เลขที่ใบอนุญาต</th>
                        <th style="width:47%">ชื่อผลิตภัณฑ์</th>
                        <th style="width:17%">ชื่อสถานที่</th>
                        <th style="width:9%">เลขสารบบ</th>
                        <th style="width:5%">วันที่รับ</th>
                        <th style="width:5%">วันที่อนุมัติ</th>
                        <th style="width:4%">สถานะ</th>
                        <th style="width:4%">ประเภทคำขอ</th>
                        <th style="width:1%">ดูข้อมูล</th>
                    </tr>
                </thead>
                <tr align="center" ng-repeat="x in allone | limitTo:itemsPerPage:itemsPerPage*(currentPage-1) ">
                    <td>{{x.RECEIVING_NUM}}</td>
                    <td>{{x.LICENSE_NUM}}</td>
                    <td>{{x.PRODUCT_NAME}}</td>
                    <td>{{x.PLACE_NAME}}</td>
                    <td>{{x.DIRECTORY_NUM}}</td>
                    <td>{{x.RCVDATE | bdate}}</td>
                    <td>{{x.APPDATE | bdate}}</td>
                    <td>{{x.STATUS_NAME}}</td>
                    <td>{{x.REQUEST_TYPE}}</td>
                    <td>{{}}</td>
                </tr>

                <tfoot>
                    <tr>
                        <td colspan="10" style="text-align:right">

                            <div class="row">
                                <div class="col-sm-2" style="text-align:right; margin-top: 10px;">
                                    จำนวน : {{(allone | filter : DATA_LIST).length}} รายการ
                                </div>
                                <div class="col-sm-1"></div>

                                <div class="col-sm-6">
                                    <ul class="d-flex justify-content-center" uib-pagination total-items="allone.length" items-per-page="10"
                                        ng-model="currentPage" max-size="5" ng-change="pageChanged()"></ul>
                                </div>
                                <div class="col-sm-auto" style="text-align:right; margin-top: 10px;">
                                    จำนวนการแสดงผล :
                                </div>
                                <div class="col-sm-1">
                                    <select class="form-control w-100" ng-model="itemsPerPage" ng-change="DRP_SET_ITEM_CHANGE()" style="padding:unset">
                                        <option value="10">10</option>
                                        <option value="20">20</option>
                                        <option value="30">30</option>
                                        <option value="50">50</option>
                                    </select>
                                </div>
                            </div>
                        </td>

                        @*<td colspan="10">
                                {{allone.lenght}}
                                <ul class="d-flex justify-content-center" uib-pagination total-items="allone.length" items-per-page="10"
                                    ng-model="currentPage" max-size="5" ng-change="pageChanged()"></ul>

                            </td>*@

                        @*<td colspan="2" style="text-align:right">
                                จำนวน : {{(DATA_STAFF_LIST | filter : txt_search | filter :{CHEM_NAME_TH:txt.CHEM_NAME_TH,CHEM_NAME:txt.CHEM_NAME,STATUS_NAME:txt.STATUS,CITIZEN_NAME:txt.CITIZEN_NAME,PROCESS_NAME:txt.PROCESS_NAME}).length}} รายการ
                            </td>*@
                    </tr>


                </tfoot>
            </table>
        </div>
        @*</div>*@
    </div>
</form>