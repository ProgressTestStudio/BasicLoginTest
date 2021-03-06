using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TestProject1
{

    public class This_is_only_a_test : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Click 'GridLink'")]
        public void This_is_only_a_test_CodedStep()
        {
            // Click 'GridLink'
            Pages.HTML5AndJavaScriptWidgets.GridLink.Click(false);
            
        }
    
        [CodedStep(@"Click 'UpdateLink'")]
        public void This_is_only_a_test_CodedStep1()
        {
            // Click 'UpdateLink'
            Pages.PopupDataEditingExample.UpdateLink.Click(false);
            
        }
    
        [CodedStep(@"Verify element 'UpdateLink' 'is' visible.")]
        public void This_is_only_a_test_CodedStep2()
        {
            // Verify element 'UpdateLink' 'is' visible.
            Pages.PopupDataEditingExample.UpdateLink.Wait.ForExists(30000);
            Assert.AreEqual(true, Pages.PopupDataEditingExample.UpdateLink.IsVisible());
                        
        }
    }
}
