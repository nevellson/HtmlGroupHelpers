<h1>asp.net mvc Html Group Helpers For bootstrap</h1>
BETA v1.0
For less html code
<p>
  When developing an html project  we usually use same tags <strong> especially on  inputs.</strong> 
 The purpose of the project leaves us to type extra html codes.
</p>

<h2>Usage</h2>
<p>
HtmlGroupHelpers have to work on html templates.
  Then , you shold define  html templates as .txt format.
  There are 3 keys available in template. 
<ul>
<li>{{input-item}} - This key has to be replaced with input. </li>
<li>{{display-for}} - This key has to be replaced with PropertyName </li>
<li>{{display-name}} - This key has to be replaced with name of the property's Display Attribute </li>
</ul>

In Web.Config there are 4 keys in the section of appSettings which can be defined by your needs.
<table>
<thead>
<tr>
<th>Key</th><th>Example</th><th>What For</th><th>Required</th>
</tr>
</thead>
<tbody>
<tr>
<td>
DefaultTemplate
</td>
<td>add key="DefaultTemplate" value="~/Content/Templates/Default.txt"</td>
<td>DefaultTemplate will be used on all undefined templates</td>
<td>Yes</td>
</tr>
<tr>
<td>CheckBoxTemplate</td>
<td>add key="CheckBoxTemplate" value="~/Content/Templates/CheckBox.txt"</td>
<td>This will be use for checkboxes.</td>
<td>No</td></tr>
<tr>
<td>DropDownTemplate</td>
<td>add key="DropDownTemplate" value="~/Content/Templates/Dropdown.txt"</td>
<td>This will be use for dropdowns. </td>
<td>No</td>
</tr>
<td>TextBoxTemplate</td>
<td>add key="TextBoxTemplate" value="~/Content/Templates/Textbox.txt"</td>
<td>This will be use for dropdowns. </td>
<td>No</td>
</tr>
</tbody>
</table>

</p>

<h2>Helpers</h2>
<ul>
<li>@Html.CheckBoxGroupFor(x => x.BooleanExampleProperty)</li>
<li>@Html.TextGroupFor(x => x.ExampleProperty)</li>
<li>@Html.DropDownGroupFor(x=>x.SelectExample,"viewDataName")</li>
</ul>
This helpers  include all  override methods.<br/>
Also in the method of DropDownGroupFor, there are overrides which include viewDataName ,instead of  IEnumerable SelecListItem.

For Example Project You can download <a href='https://github.com/ierhalim/HtmlGroupHelperExampleProject'> HtmlGroupHelperExampleproject</a>
