#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult PreviewMode()
        {
            ViewBag.Value = @"In Rich Text Editor , you click the toolbar buttons to format the words and the changes are visible immediately. 
Markdown is not like that. When you format the word in Markdown format, you need to add Markdown syntax to the word to indicate which words 
and phrases should look different from each other

Rich Text Editor supports markdown editing when the editorMode set as **markdown** and using both *keyboard interaction* and *toolbar action*, you can apply the formatting to text.

We can add our own custom formation syntax for the Markdown formation, [sample link](https://ej2.syncfusion.com/home/).

The third-party library <b>Marked</b> is used in this sample to convert markdown into HTML content";
            ViewBag.Items = new object[] {"Bold", "Italic", "StrikeThrough", "|", "Formats", "OrderedList", "UnorderedList", "|", "CreateTable", "CreateLink", "Image", "|",
                            new {
                            tooltipText =  "Preview", template = @"<button id='preview-code' class='e-tbar-btn e-control e-btn e-icon-btn'>
                                    <span class='e-btn-icon e-md-preview e-icons'></span></button>" },
                            new {
                            tooltipText = "Split Editor", template = @"<button id='MD_Preview' class='e-tbar-btn e-control e-btn e-icon-btn'>
                                    <span class='e-btn-icon e-view-side e-icons'></span></button>" }, "FullScreen", "|", "Undo", "Redo" };

            return View();
        }
    }
}
