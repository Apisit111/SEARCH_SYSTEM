<!DOCTYPE html>
<html>
    <head>
        @Html.Partial("Metadata", Nothing)
        <title>สำนักงานคณะกรรมการอาหารและยา</title>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name='created_by' content='This is example, please fill you name.'>
        <link href="../Design/css-spinners-master/css/spinners.css" rel="stylesheet" />
    </head>
    <body ng-app="SEARCH_SESTEM" ng-controller="AUTHEN_GATEWAY_CTRL">

        <div class="loading-spiner-holder" data-loading style="background:#04adfd40;width: 100%;height: 100%;position: fixed;z-index: 99999;">
             <div class="loading-spiner">

             </div>
        </div>
        <div class="page-loading" data-loading style="width: 100%;height: 100%;position: fixed;z-index: 99999;">
            <div class="loader">
                <span class="box"></span>
                <span class="box"></span>
                <div class="code">
                    <img src="~/Design/Images/oy.png" style="width:100px">
                </div>
                <span class="txt" style="font-size:1em;color:white">กำลังเตรียมข้อมูล...</span>
            </div>
        </div>
        @Html.Partial("header", Nothing)

        <div class="wrap-main-content">
            <div id="page">
                <div class="content-overlay"></div>
                @*@Html.Partial("menu_popup", Nothing)
                <div id="page-adr-2019">
                    <div class="page-header">
                        <div class="card-tab-control page-header-content header-elements-md-inline container">
                            <div class="tab-content" ng-repeat="datas in FULL_MODEL.SET_PAGE_MAIN">
                                <div data-index="{{datas.IDA}}" class="tab-content-item " ng-click="BTN_MENU_CLICK(datas.PagePath,datas.PageName,datas.IDA,datas.ProcessID)">
                                    {{datas.PageName}}
                                </div>
                            </div>
                        </div>

                        <div class="clearfix"></div>
                    </div>*@
                <div class="page-content container-fluid ">
                    <div class="content-wrapper" style="overflow:unset;">
                        <div class="content">
                            <div ng-include="SET_MAIN_PAGE">

                            </div>
                        </div>
                    </div>
                </div>
                @*</div>*@
            </div>



            <footer>
                <div class="ft1">
                    สำนักงานคณะกรรมการอาหารและยา กระทรวงสาธารณสุข
                </div>
                <div class="ft2">
                    88/24 ถนนติวานนท์ อ.เมือง จ.นนทบุรี 11000 <br>
                    โทรศัพท์ 0-2590-7000
                </div>
            </footer>
        </div>
    </body>
</html>