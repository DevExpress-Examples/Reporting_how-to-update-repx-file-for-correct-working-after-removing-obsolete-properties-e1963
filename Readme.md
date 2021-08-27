<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603758/12.2.15%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1963)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RestoreLayoutWithOverlappedOptions/Form1.cs) (VB: [Form1.vb](./VB/RestoreLayoutWithOverlappedOptions/Form1.vb))
* [Program.cs](./CS/RestoreLayoutWithOverlappedOptions/Program.cs) (VB: [Program.vb](./VB/RestoreLayoutWithOverlappedOptions/Program.vb))
<!-- default file list end -->
# How to update REPX file for correct working after removing obsolete properties


<p>This example illustrates how to update report saved to the REPX files in order to be able to work with them after removing any obsolete properties of the report's controls. Unfortunately there is no built-in capability to upgrade your reports, so you might need to iterate through the corresponding file and update it accordingly. In this particular scenario report layout is updated to remove obsolete OverlappingOptions property (please refer to the Breaking Changes list posted at <a href="http://www.devexpress.com/Support/WhatsNew/DXperience/files/9.3.2.bc.xml#autolist15">http://www.devexpress.com/Support/WhatsNew/DXperience/files/9.3.2.bc.xml#autolist15</a>).</p>

<br/>


