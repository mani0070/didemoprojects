﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUIdisample
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// BrowsePagesSample - Use 'BrowsePagesSampleParams' to pass parameters into this method.
        /// </summary>
        public void BrowsePagesSample()
        {
            #region Variable Declarations
            HtmlCustom uIMainCustom = this.UIMSNUKHotmailOutlookSWindow.UIMSNUKHotmailOutlookSDocument.UIMainCustom;
            HtmlHyperlink uIPoliceprobeHopkinsovHyperlink = this.UIMSNUKHotmailOutlookSWindow.UIMSNUKHotmailOutlookSDocument.UIMainCustom.UIPoliceprobeHopkinsovHyperlink;
            WinClient uIAddressBarClient = this.UIMSNUKHotmailOutlookSWindow.UIAddressBarWindow.UIAddressBarClient;
            BrowserWindow uIMSNUKHotmailOutlookSWindow = this.UIMSNUKHotmailOutlookSWindow;
            HtmlHyperlink uIAPIHyperlink = this.UIMSNUKHotmailOutlookSWindow.UIHomePageDocument.UIAPIHyperlink;
            HtmlCell uIPOSTapiAccountChangeCell = this.UIMSNUKHotmailOutlookSWindow.UIASPNETWebAPIHelpPageDocument.UIBodyPane.UIItemTable.UIPOSTapiAccountChangeCell;
            HtmlHyperlink uIPOSTapiAccountChangeHyperlink = this.UIMSNUKHotmailOutlookSWindow.UIASPNETWebAPIHelpPageDocument.UIBodyPane.UIPOSTapiAccountChangeHyperlink;
            HtmlDocument uIPOSTapiAccountChangeDocument = this.UIMSNUKHotmailOutlookSWindow.UIPOSTapiAccountChangeDocument;
            HtmlDiv uIRequestInformationURPane = this.UIMSNUKHotmailOutlookSWindow.UIPOSTapiAccountChangeDocument.UIBodyPane.UIRequestInformationURPane;
            #endregion

            // Go to web page 'http://www.msn.com/?pc=MSE1' using new browser instance
            this.UIMSNUKHotmailOutlookSWindow.LaunchUrl(new System.Uri(this.BrowsePagesSampleParams.UIMSNUKHotmailOutlookSWindowUrl));

                        // Click 'Address Bar' client
            Mouse.Click(uIAddressBarClient, new Point(375, -6));

            // Go to web page 'http://ditfs.cloudapp.net:432/'
            uIMSNUKHotmailOutlookSWindow.NavigateToUrl(new System.Uri(this.BrowsePagesSampleParams.UIMSNUKHotmailOutlookSWindowUrl1));

            // Click 'API' link
            Mouse.Click(uIAPIHyperlink, new Point(41, 39));

            // Click 'POST api/Account/ChangePassword' cell
            Mouse.Click(uIPOSTapiAccountChangeCell, new Point(185, 60));

            // Click 'POST api/Account/ChangePassword' link
            Mouse.Click(uIPOSTapiAccountChangeHyperlink, new Point(202, 23));

            // Type '{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}' in 'POST api/Account/ChangePassword' document
            Keyboard.SendKeys(uIPOSTapiAccountChangeDocument, this.BrowsePagesSampleParams.UIPOSTapiAccountChangeDocumentSendKeys, ModifierKeys.None);

            // Double-Click 'Request Information URI Parameters' pane
            Mouse.DoubleClick(uIRequestInformationURPane, new Point(7, 99));

            // Move 'Request Information URI Parameters' pane
            Mouse.StartDragging(uIRequestInformationURPane, new Point(8, 98));
            Mouse.StopDragging(uIRequestInformationURPane, 255, -28);

            // Double-Click 'Request Information URI Parameters' pane
            Mouse.DoubleClick(uIRequestInformationURPane, new Point(127, 82));

            // Double-Click 'Request Information URI Parameters' pane
            Mouse.DoubleClick(uIRequestInformationURPane, new Point(127, 82));

            // Click 'Request Information URI Parameters' pane
            Mouse.Click(uIRequestInformationURPane, new Point(127, 82));

            // Right-Click 'Request Information URI Parameters' pane
            Mouse.Click(uIRequestInformationURPane, MouseButtons.Right, ModifierKeys.None, new Point(127, 82));
        }
        
        /// <summary>
        /// BrowseSampleUserInfo
        /// </summary>
        public void BrowseSampleUserInfo()
        {
            #region Variable Declarations
            HtmlHyperlink uIAPIHyperlink = this.UIMSNUKHotmailOutlookSWindow.UIHomePageDocument.UIAPIHyperlink;
            HtmlHyperlink uIGETapiAccountUserInfHyperlink = this.UIMSNUKHotmailOutlookSWindow.UIASPNETWebAPIHelpPageDocument.UIBodyPane.UIGETapiAccountUserInfHyperlink;
            #endregion

            // Click 'API' link
            Mouse.Click(uIAPIHyperlink, new Point(7, 32));

            // Click 'GET api/Account/UserInfo' link
            Mouse.Click(uIGETapiAccountUserInfHyperlink, new Point(181, 9));
        }
        
        #region Properties
        public virtual BrowsePagesSampleParams BrowsePagesSampleParams
        {
            get
            {
                if ((this.mBrowsePagesSampleParams == null))
                {
                    this.mBrowsePagesSampleParams = new BrowsePagesSampleParams();
                }
                return this.mBrowsePagesSampleParams;
            }
        }
        
        public UIMSNUKHotmailOutlookSWindow UIMSNUKHotmailOutlookSWindow
        {
            get
            {
                if ((this.mUIMSNUKHotmailOutlookSWindow == null))
                {
                    this.mUIMSNUKHotmailOutlookSWindow = new UIMSNUKHotmailOutlookSWindow();
                }
                return this.mUIMSNUKHotmailOutlookSWindow;
            }
        }
        #endregion
        
        #region Fields
        private BrowsePagesSampleParams mBrowsePagesSampleParams;
        
        private UIMSNUKHotmailOutlookSWindow mUIMSNUKHotmailOutlookSWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'BrowsePagesSample'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class BrowsePagesSampleParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://www.msn.com/?pc=MSE1' using new browser instance
        /// </summary>
        public string UIMSNUKHotmailOutlookSWindowUrl = "http://www.msn.com/?pc=MSE1";
        
        /// <summary>
        /// Go to web page 'http://ditfs.cloudapp.net:432/'
        /// </summary>
        public string UIMSNUKHotmailOutlookSWindowUrl1 = "http://ditfs.cloudapp.net:432/";
        
        /// <summary>
        /// Type '{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}' in 'POST api/Account/ChangePassword' document
        /// </summary>
        public string UIPOSTapiAccountChangeDocumentSendKeys = "{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Down}{Do" +
            "wn}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{Up}{" +
            "Up}{Up}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIMSNUKHotmailOutlookSWindow : BrowserWindow
    {
        
        public UIMSNUKHotmailOutlookSWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "MSN UK | Hotmail, Outlook, Skype, Bing, Latest News, Photos and Videos";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("MSN UK | Hotmail, Outlook, Skype, Bing, Latest News, Photos and Videos");
            this.WindowTitles.Add("Home Page");
            this.WindowTitles.Add("ASP.NET Web API Help Page");
            this.WindowTitles.Add("POST api/Account/ChangePassword");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIMSNUKHotmailOutlookSDocument UIMSNUKHotmailOutlookSDocument
        {
            get
            {
                if ((this.mUIMSNUKHotmailOutlookSDocument == null))
                {
                    this.mUIMSNUKHotmailOutlookSDocument = new UIMSNUKHotmailOutlookSDocument(this);
                }
                return this.mUIMSNUKHotmailOutlookSDocument;
            }
        }
        
        public UIAddressBarWindow UIAddressBarWindow
        {
            get
            {
                if ((this.mUIAddressBarWindow == null))
                {
                    this.mUIAddressBarWindow = new UIAddressBarWindow(this);
                }
                return this.mUIAddressBarWindow;
            }
        }
        
        public UIHomePageDocument UIHomePageDocument
        {
            get
            {
                if ((this.mUIHomePageDocument == null))
                {
                    this.mUIHomePageDocument = new UIHomePageDocument(this);
                }
                return this.mUIHomePageDocument;
            }
        }
        
        public UIASPNETWebAPIHelpPageDocument UIASPNETWebAPIHelpPageDocument
        {
            get
            {
                if ((this.mUIASPNETWebAPIHelpPageDocument == null))
                {
                    this.mUIASPNETWebAPIHelpPageDocument = new UIASPNETWebAPIHelpPageDocument(this);
                }
                return this.mUIASPNETWebAPIHelpPageDocument;
            }
        }
        
        public UIPOSTapiAccountChangeDocument UIPOSTapiAccountChangeDocument
        {
            get
            {
                if ((this.mUIPOSTapiAccountChangeDocument == null))
                {
                    this.mUIPOSTapiAccountChangeDocument = new UIPOSTapiAccountChangeDocument(this);
                }
                return this.mUIPOSTapiAccountChangeDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIMSNUKHotmailOutlookSDocument mUIMSNUKHotmailOutlookSDocument;
        
        private UIAddressBarWindow mUIAddressBarWindow;
        
        private UIHomePageDocument mUIHomePageDocument;
        
        private UIASPNETWebAPIHelpPageDocument mUIASPNETWebAPIHelpPageDocument;
        
        private UIPOSTapiAccountChangeDocument mUIPOSTapiAccountChangeDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIMSNUKHotmailOutlookSDocument : HtmlDocument
    {
        
        public UIMSNUKHotmailOutlookSDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "MSN UK | Hotmail, Outlook, Skype, Bing, Latest News, Photos and Videos";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/en-gb/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://www.msn.com/en-gb/?pc=MSE1";
            this.WindowTitles.Add("MSN UK | Hotmail, Outlook, Skype, Bing, Latest News, Photos and Videos");
            #endregion
        }
        
        #region Properties
        public UIMainCustom UIMainCustom
        {
            get
            {
                if ((this.mUIMainCustom == null))
                {
                    this.mUIMainCustom = new UIMainCustom(this);
                }
                return this.mUIMainCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIMainCustom mUIMainCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIMainCustom : HtmlCustom
    {
        
        public UIMainCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "main";
            this.SearchProperties["Id"] = "main";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"main\" role=\"main\" data-m=\"{\'i\':32,\'n";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("MSN UK | Hotmail, Outlook, Skype, Bing, Latest News, Photos and Videos");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIPoliceprobeHopkinsovHyperlink
        {
            get
            {
                if ((this.mUIPoliceprobeHopkinsovHyperlink == null))
                {
                    this.mUIPoliceprobeHopkinsovHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIPoliceprobeHopkinsovHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIPoliceprobeHopkinsovHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIPoliceprobeHopkinsovHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIPoliceprobeHopkinsovHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = " \r\nPolice probe Hopkins over \'cockroach migrants\' slur\r\n\r\n The Independent ";
                    this.mUIPoliceprobeHopkinsovHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/en-gb/news/uknews/katie-hopkins-and-the-sun-editor-reported-to-police-for-incite" +
                        "ment-to-racial-hatred-following-migrant-boat-column/ar-AAbnVV5";
                    this.mUIPoliceprobeHopkinsovHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIPoliceprobeHopkinsovHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://www.msn.com/en-gb/news/uknews/katie-hopkins-and-the-sun-editor-reported-to" +
                        "-police-for-incitement-to-racial-hatred-following-migrant-boat-column/ar-AAbnVV5" +
                        "";
                    this.mUIPoliceprobeHopkinsovHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIPoliceprobeHopkinsovHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/en-gb/news/uknews/katie-hopkins-a";
                    this.mUIPoliceprobeHopkinsovHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "65";
                    this.mUIPoliceprobeHopkinsovHyperlink.WindowTitles.Add("MSN UK | Hotmail, Outlook, Skype, Bing, Latest News, Photos and Videos");
                    #endregion
                }
                return this.mUIPoliceprobeHopkinsovHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIPoliceprobeHopkinsovHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIAddressBarWindow : WinWindow
    {
        
        public UIAddressBarWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "41477";
            this.WindowTitles.Add("MSN UK | Hotmail, Outlook, Skype, Bing, Latest News, Photos and Videos");
            #endregion
        }
        
        #region Properties
        public WinClient UIAddressBarClient
        {
            get
            {
                if ((this.mUIAddressBarClient == null))
                {
                    this.mUIAddressBarClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIAddressBarClient.SearchProperties[WinControl.PropertyNames.Name] = "Address Bar";
                    this.mUIAddressBarClient.WindowTitles.Add("MSN UK | Hotmail, Outlook, Skype, Bing, Latest News, Photos and Videos");
                    #endregion
                }
                return this.mUIAddressBarClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIAddressBarClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHomePageDocument : HtmlDocument
    {
        
        public UIHomePageDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://ditfs.cloudapp.net:432/";
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIAPIHyperlink
        {
            get
            {
                if ((this.mUIAPIHyperlink == null))
                {
                    this.mUIAPIHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIAPIHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIAPIHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIAPIHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIAPIHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "API";
                    this.mUIAPIHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Help";
                    this.mUIAPIHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIAPIHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://ditfs.cloudapp.net:432/Help";
                    this.mUIAPIHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIAPIHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Help\"";
                    this.mUIAPIHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUIAPIHyperlink.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIAPIHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIAPIHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIASPNETWebAPIHelpPageDocument : HtmlDocument
    {
        
        public UIASPNETWebAPIHelpPageDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "ASP.NET Web API Help Page";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Help";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://ditfs.cloudapp.net:432/Help";
            this.WindowTitles.Add("ASP.NET Web API Help Page");
            #endregion
        }
        
        #region Properties
        public UIBodyPane UIBodyPane
        {
            get
            {
                if ((this.mUIBodyPane == null))
                {
                    this.mUIBodyPane = new UIBodyPane(this);
                }
                return this.mUIBodyPane;
            }
        }
        #endregion
        
        #region Fields
        private UIBodyPane mUIBodyPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIBodyPane : HtmlDiv
    {
        
        public UIBodyPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "body";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Introduction\r\n\r\nProvide a general descri";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "help-page";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"help-page\" id=\"body\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "8";
            this.WindowTitles.Add("ASP.NET Web API Help Page");
            #endregion
        }
        
        #region Properties
        public UIItemTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new UIItemTable(this);
                }
                return this.mUIItemTable;
            }
        }
        
        public HtmlHyperlink UIPOSTapiAccountChangeHyperlink
        {
            get
            {
                if ((this.mUIPOSTapiAccountChangeHyperlink == null))
                {
                    this.mUIPOSTapiAccountChangeHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIPOSTapiAccountChangeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIPOSTapiAccountChangeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIPOSTapiAccountChangeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIPOSTapiAccountChangeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "POST api/Account/ChangePassword";
                    this.mUIPOSTapiAccountChangeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Help/Api/POST-api-Account-ChangePassword";
                    this.mUIPOSTapiAccountChangeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIPOSTapiAccountChangeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://ditfs.cloudapp.net:432/Help/Api/POST-api-Account-ChangePassword";
                    this.mUIPOSTapiAccountChangeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIPOSTapiAccountChangeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Help/Api/POST-api-Account-ChangeP";
                    this.mUIPOSTapiAccountChangeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "4";
                    this.mUIPOSTapiAccountChangeHyperlink.WindowTitles.Add("ASP.NET Web API Help Page");
                    #endregion
                }
                return this.mUIPOSTapiAccountChangeHyperlink;
            }
        }
        
        public HtmlHyperlink UIGETapiAccountUserInfHyperlink
        {
            get
            {
                if ((this.mUIGETapiAccountUserInfHyperlink == null))
                {
                    this.mUIGETapiAccountUserInfHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIGETapiAccountUserInfHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIGETapiAccountUserInfHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIGETapiAccountUserInfHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIGETapiAccountUserInfHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "GET api/Account/UserInfo";
                    this.mUIGETapiAccountUserInfHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Help/Api/GET-api-Account-UserInfo";
                    this.mUIGETapiAccountUserInfHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIGETapiAccountUserInfHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://ditfs.cloudapp.net:432/Help/Api/GET-api-Account-UserInfo";
                    this.mUIGETapiAccountUserInfHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIGETapiAccountUserInfHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Help/Api/GET-api-Account-UserInfo";
                    this.mUIGETapiAccountUserInfHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIGETapiAccountUserInfHyperlink.WindowTitles.Add("ASP.NET Web API Help Page");
                    #endregion
                }
                return this.mUIGETapiAccountUserInfHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private UIItemTable mUIItemTable;
        
        private HtmlHyperlink mUIPOSTapiAccountChangeHyperlink;
        
        private HtmlHyperlink mUIGETapiAccountUserInfHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = null;
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties[HtmlTable.PropertyNames.InnerText] = "API\r\n\r\nDescription\r\n\r\n\r\nGET api/Account/";
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "class=\"help-page-table\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "12";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "help-page-table";
            this.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("ASP.NET Web API Help Page");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIPOSTapiAccountChangeCell
        {
            get
            {
                if ((this.mUIPOSTapiAccountChangeCell == null))
                {
                    this.mUIPOSTapiAccountChangeCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIPOSTapiAccountChangeCell.SearchProperties[HtmlCell.PropertyNames.Id] = null;
                    this.mUIPOSTapiAccountChangeCell.SearchProperties[HtmlCell.PropertyNames.Name] = null;
                    this.mUIPOSTapiAccountChangeCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIPOSTapiAccountChangeCell.SearchProperties[HtmlCell.PropertyNames.InnerText] = "POST api/Account/ChangePassword";
                    this.mUIPOSTapiAccountChangeCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "class=\"api-name\"";
                    this.mUIPOSTapiAccountChangeCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "4";
                    this.mUIPOSTapiAccountChangeCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                    this.mUIPOSTapiAccountChangeCell.FilterProperties[HtmlCell.PropertyNames.Class] = "api-name";
                    this.mUIPOSTapiAccountChangeCell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "7";
                    this.mUIPOSTapiAccountChangeCell.WindowTitles.Add("ASP.NET Web API Help Page");
                    #endregion
                }
                return this.mUIPOSTapiAccountChangeCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIPOSTapiAccountChangeCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIPOSTapiAccountChangeDocument : HtmlDocument
    {
        
        public UIPOSTapiAccountChangeDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "POST api/Account/ChangePassword";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Help/Api/POST-api-Account-ChangePassword";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://ditfs.cloudapp.net:432/Help/Api/POST-api-Account-ChangePassword";
            this.WindowTitles.Add("POST api/Account/ChangePassword");
            #endregion
        }
        
        #region Properties
        public UIBodyPane1 UIBodyPane
        {
            get
            {
                if ((this.mUIBodyPane == null))
                {
                    this.mUIBodyPane = new UIBodyPane1(this);
                }
                return this.mUIBodyPane;
            }
        }
        #endregion
        
        #region Fields
        private UIBodyPane1 mUIBodyPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIBodyPane1 : HtmlDiv
    {
        
        public UIBodyPane1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "body";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Help Page Home \r\n\r\n\r\nPOST api/Account/Ch";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "help-page";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"help-page\" id=\"body\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "6";
            this.WindowTitles.Add("POST api/Account/ChangePassword");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIRequestInformationURPane
        {
            get
            {
                if ((this.mUIRequestInformationURPane == null))
                {
                    this.mUIRequestInformationURPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIRequestInformationURPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIRequestInformationURPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIRequestInformationURPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Request Information\r\n\r\nURI Parameters\r\n\r";
                    this.mUIRequestInformationURPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIRequestInformationURPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIRequestInformationURPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = null;
                    this.mUIRequestInformationURPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "8";
                    this.mUIRequestInformationURPane.WindowTitles.Add("POST api/Account/ChangePassword");
                    #endregion
                }
                return this.mUIRequestInformationURPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIRequestInformationURPane;
        #endregion
    }
}
