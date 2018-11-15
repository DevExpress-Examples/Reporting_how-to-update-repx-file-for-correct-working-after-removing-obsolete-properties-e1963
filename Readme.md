<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RestoreLayoutWithOverlappedOptions/Form1.cs) (VB: [Form1.vb](./VB/RestoreLayoutWithOverlappedOptions/Form1.vb))
* [Program.cs](./CS/RestoreLayoutWithOverlappedOptions/Program.cs) (VB: [Program.vb](./VB/RestoreLayoutWithOverlappedOptions/Program.vb))
<!-- default file list end -->
# How to update REPX file for correct working after removing obsolete properties


<p>This example illustrates how to update report saved to the REPX files in order to be able to work with them after removing any obsolete properties of the report's controls. Unfortunately there is no built-in capability to upgrade your reports, so you might need to iterate through the corresponding file and update it accordingly. In this particular scenario report layout is updated to remove obsolete OverlappingOptions property (please refer to the Breaking Changes list posted at <a href="http://www.devexpress.com/Support/WhatsNew/DXperience/files/9.3.2.bc.xml#autolist15">http://www.devexpress.com/Support/WhatsNew/DXperience/files/9.3.2.bc.xml#autolist15</a>).</p>

<br/>


