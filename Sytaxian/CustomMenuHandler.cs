using System;
using CefSharp;
using System.Windows.Forms;

public class CustomMenuHandler : IContextMenuHandler
{
    public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
    {
        // Remove any existent option using the Clear method of the model
        //
        //model.Clear();

        Console.WriteLine("Context menu opened !");
        model.AddItem((CefMenuCommand)26502, "Reload");

        // You can add a separator in case that there are more items on the list
        if (model.Count > 0)
        {
            model.AddSeparator();
        }


        // Add a new item to the list using the AddItem method of the model
        model.AddItem((CefMenuCommand)26501, "Show DevTools");


        // Add a separator
        model.AddSeparator();

        // Add another example item
        model.AddItem((CefMenuCommand)26503, "Sytax Website");
    }

    public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
    {
        // React to the first ID (show dev tools method)
        if (commandId == (CefMenuCommand)26501)
        {
            browser.GetHost().ShowDevTools();
            return true;
        }

        // React to the second ID (show dev tools method)
        if (commandId == (CefMenuCommand)26502)
        {
            browser.Reload();
            return true;
        }

        // React to the third ID (Display alert message)
        if (commandId == (CefMenuCommand)26503)
        {
            browser.MainFrame.LoadUrl("https://sytax.xyz");
            return true;
        }

        // Any new item should be handled through a new if statement


        // Return false should ignore the selected option of the user !
        return false;
    }

    public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
    {

    }

    public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
    {
        return false;
    }
}