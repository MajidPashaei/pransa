#pragma checksum "f:\Projects\pransa\pransa\Areas\Admin\Views\Sourcehelp\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sourcehelp_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Sourcehelp/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "f:\Projects\pransa\pransa\Areas\Admin\Views\_ViewImports.cshtml"
using pransa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "f:\Projects\pransa\pransa\Areas\Admin\Views\_ViewImports.cshtml"
using pransa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a", @"/Areas/Admin/Views/Sourcehelp/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9350ba188a92905cd0fa77d4c02b448aed126f56", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sourcehelp_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropzone dropzone-area"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dataListUpload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <!-- BEGIN: Content-->
<section id=""data-list-view"" class=""data-list-view-header"">
  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>نام</th>
          <th>دسته بندی</th>
          <th>مردم</th>
          <th>وضعیت سفارش</th>
          <th>قیمت</th>
          <th>اقدام</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td></td>
          <td class=""product-name"">اپل واچ سری 4 GPS</td>
          <td class=""product-category"">کامپیوترها</td>
          <td>
            <div class=""progress progress-bar-success"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:97%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-warning"">
              <div class=""chip-body"">
                <div class=""chip-text"">در انتظار</div>
           ");
            WriteLiteral(@"   </div>
            </div>
          </td>
          <td class=""product-price"">699,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">هدفون Beats</td>
          <td class=""product-category"">کامپیوترها</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:83%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-success"">
              <div class=""chip-body"">
                <div class=""chip-text"">تحویل داده شده</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">699,900 ريال</td>
          <td c");
            WriteLiteral(@"lass=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Altec Lansing - بلندگو بلوتوث</td>
          <td class=""product-category"">صدا</td>
          <td>
            <div class=""progress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:57%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-danger"">
              <div class=""chip-body"">
                <div class=""chip-text"">لغو شد</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,999,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
          ");
            WriteLiteral(@"  <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Aluratek - گیرنده صوتی بلوتوث</td>
          <td class=""product-category"">کامپیوترها</td>
          <td>
            <div class=""progress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:65%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-warning"">
              <div class=""chip-body"">
                <div class=""chip-text"">در انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">299,990 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
");
            WriteLiteral(@"        <tr>
          <td></td>
          <td class=""product-name"">Aluratek - فرستنده صوتی بلوتوث</td>
          <td class=""product-category"">صدا</td>
          <td>
            <div class=""progress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:87%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-danger"">
              <div class=""chip-body"">
                <div class=""chip-text"">لغو شد</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,999,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">مبانی - پیک تناسب اندام و ردیاب خواب</td>
");
            WriteLiteral(@"          <td class=""product-category"">تناسب اندام</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:47%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-warning"">
              <div class=""chip-body"">
                <div class=""chip-text"">در انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,999,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Antec - ترکیب گرمایی الماس نانو</td>
          <td class=""product-category"">تناسب اندام</td>
          <td>
            <div class=""pro");
            WriteLiteral(@"gress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:55%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-primary"">
              <div class=""chip-body"">
                <div class=""chip-text"">انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">299,990 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Antec - آداپتور بلوتوث SmartBean</td>
          <td class=""product-category"">کامپیوتر</td>
          <td>
            <div class=""progress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40""");
            WriteLiteral(@" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:63%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-danger"">
              <div class=""chip-body"">
                <div class=""chip-text"">لغو شد</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">3,999,000 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Beats by Dr. Dre - 3' USB-to-Micro USB Cable</td>
          <td class=""product-category"">کامپیوتر</td>
          <td>
            <div class=""progress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:87%""></div>
            </div>
        ");
            WriteLiteral(@"  </td>
          <td>
            <div class=""chip chip-success"">
              <div class=""chip-body"">
                <div class=""chip-text"">None</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,999,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Beats by Dr. Dre - Bike Mount for Pill Speakers</td>
          <td class=""product-category"">صدا</td>
          <td>
            <div class=""progress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:40%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-warning"">
              <div class=""c");
            WriteLiteral(@"hip-body"">
                <div class=""chip-text"">None</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">499,990 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Bose ® - SoundLink ® بلندگو بلوتوث رنگی</td>
          <td class=""product-category"">تناسب اندام</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:90%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-primary"">
              <div class=""chip-body"">
                <div class=""chip-text"">انتظار</div>
              </div>
            ");
            WriteLiteral(@"</div>
          </td>
          <td class=""product-price"">1,299,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">BRAVEN - بلندگو بلوتوث قابل حمل</td>
          <td class=""product-category"">تناسب اندام</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:87%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-warning"">
              <div class=""chip-body"">
                <div class=""chip-text"">در انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,999,900 ريال</td>
          <td clas");
            WriteLiteral(@"s=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">کریگ - بلندگو بی سیم قابل حمل</td>
          <td class=""product-category"">کامپیوترها</td>
          <td>
            <div class=""progress progress-bar-danger"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:20%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-danger"">
              <div class=""chip-body"">
                <div class=""chip-text"">لغو شد</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,999,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
       ");
            WriteLiteral(@"     <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">فناوری قطعی - بلندگو بی سیم</td>
          <td class=""product-category"">تناسب اندام</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:75%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-primary"">
              <div class=""chip-body"">
                <div class=""chip-text"">انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">3,999,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>");
            WriteLiteral(@"
        <tr>
          <td></td>
          <td class=""product-name"">Fitbit - Charge HR Activity Tracker + Heart Rate (Large)</td>
          <td class=""product-category"">صدا</td>
          <td>
            <div class=""progress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:60%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-primary"">
              <div class=""chip-body"">
                <div class=""chip-text"">انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,499,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Fitbit - Flex 1");
            WriteLiteral(@""" USB Charging Cable</td>
          <td class=""product-category"">تناسب اندام</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:87%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-warning"">
              <div class=""chip-body"">
                <div class=""chip-text"">در انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">149,990 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Fitbit - ردیاب فعالیت</td>
          <td class=""product-category"">تناسب اندام</td>
          <td>
            ");
            WriteLiteral(@"<div class=""progress progress-bar-danger"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:35%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-danger"">
              <div class=""chip-body"">
                <div class=""chip-text"">لغو شد</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">999,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Fitbit - Charge Wireless Activity Tracker (Large)</td>
          <td class=""product-category"">کامپیوترها</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=");
            WriteLiteral(@"""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:87%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-primary"">
              <div class=""chip-body"">
                <div class=""chip-text"">انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,299,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">کریگ - بلندگو </td>
          <td class=""product-category"">صدا</td>
          <td>
            <div class=""progress progress-bar-warning"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:68%""></div>
            </div>
          ");
            WriteLiteral(@"</td>
          <td>
            <div class=""chip chip-warning"">
              <div class=""chip-body"">
                <div class=""chip-text"">در انتظار</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">699,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">براون - بلندگو در فضای باز</td>
          <td class=""product-category"">کامپیوترها</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:97%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-success"">
              <div class=""chip-body"">
 ");
            WriteLiteral(@"               <div class=""chip-text"">None</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,999,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Bose® - کیسه سفر بلندگو بلوتوث</td>
          <td class=""product-category"">کامپیوترها</td>
          <td>
            <div class=""progress progress-bar-primary"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:89%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-warning"">
              <div class=""chip-body"">
                <div class=""chip-text"">در انتظار</div>
              </div>
            </div>
          ");
            WriteLiteral(@"</td>
          <td class=""product-price"">449,900 ريال</td>
          <td class=""product-action"">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
        <tr>
          <td></td>
          <td class=""product-name"">Altec Lansing - بلندگو بلوتوث Mini H2O</td>
          <td class=""product-category"">تناسب اندام</td>
          <td>
            <div class=""progress progress-bar-success"">
              <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""40"" aria-valuemax=""100"" style=""width:87%""></div>
            </div>
          </td>
          <td>
            <div class=""chip chip-success"">
              <div class=""chip-body"">
                <div class=""chip-text"">None</div>
              </div>
            </div>
          </td>
          <td class=""product-price"">1,999,900 ريال</td>
          <td class=""product-action""");
            WriteLiteral(@">
            <span class=""action-edit""><i class=""feather icon-edit""></i></span>
            <span class=""action-delete""><i class=""feather icon-trash""></i></span>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
  <!-- DataTable ends -->

  <!-- add new sidebar starts -->
  <div class=""add-new-data-sidebar"">
    <div class=""overlay-bg""></div>
    <div class=""add-new-data"">
      <div class=""div mt-2 px-2 d-flex new-data-title justify-content-between"">
        <div>
          <h4 class=""text-uppercase"">نمایش داده های لیست</h4>
        </div>
        <div class=""hide-data-sidebar"">
          <i class=""feather icon-x""></i>
        </div>
      </div>
      <div class=""data-items pb-3"">
        <div class=""data-fields px-2 mt-3"">
          <div class=""row"">
            <div class=""col-sm-12 data-field-col"">
              <label for=""data-name"">نام</label>
              <input type=""text"" class=""form-control"" id=""data-name"">
            </div>
            <div class=""");
            WriteLiteral("col-sm-12 data-field-col\">\r\n              <label for=\"data-category\">  دسته بندی</label>\r\n              <select class=\"form-control\" id=\"data-category\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a27614", async() => {
                WriteLiteral("صدا");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a28586", async() => {
                WriteLiteral("کامپیوترها");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a29565", async() => {
                WriteLiteral("تناسب اندام");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a30545", async() => {
                WriteLiteral("لوازم خانگی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              </select>\r\n            </div>\r\n            <div class=\"col-sm-12 data-field-col\">\r\n              <label for=\"data-status\">وضعیت سفارش</label>\r\n              <select class=\"form-control\" id=\"data-status\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a31762", async() => {
                WriteLiteral("در انتظار");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a32740", async() => {
                WriteLiteral("لغو شد");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a33715", async() => {
                WriteLiteral("تحویل داده شده");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a34698", async() => {
                WriteLiteral("در انتظار");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              </select>
            </div>
            <div class=""col-sm-12 data-field-col"">
              <label for=""data-price"">قیمت</label>
              <input type=""text"" class=""form-control"" id=""data-price"">
            </div>
            <div class=""col-sm-12 data-field-col data-list-upload"">
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cfa1f5fbb32e5f6e8063a78938cc060f30b35a35995", async() => {
                WriteLiteral("\r\n                <div class=\"dz-message\">بارگذاری تصویر</div>\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
          </div>
        </div>
      </div>
      <div class=""add-data-footer d-flex justify-content-around px-3 mt-2"">
        <div class=""add-data-btn"">
          <button class=""btn btn-primary"">داده را اضافه کنید</button>
        </div>
        <div class=""cancel-data-btn"">
          <button class=""btn btn-outline-danger"">لغو</button>
        </div>
      </div>
    </div>
  </div>
  <!-- add new sidebar ends -->
</section>
<!-- Data list view end -->

        </div>
      </div>
    </div>
    <!-- END: Content-->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
