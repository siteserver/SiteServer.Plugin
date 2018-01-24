using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.UI.WebControls;

namespace SiteServer.Plugin
{
    public interface IService
    {
        // 
        // Action<object, FileSystemEventArgs> FileSystemChanged { get; }

        IService AddPluginMenu(Menu menu);

        IService AddSiteMenu(Func<int, Menu> siteMenuFunc);

        IService AddContentModel(string tableName, List<TableColumn> tableColumns);

        IService AddDatabaseTable(string tableName, List<TableColumn> tableColumns);

        IService AddContentLinks(List<HyperLink> links);

        event EventHandler<ContentEventArgs> ContentAddCompleted;

        event EventHandler<ContentEventArgs> ContentDeleteCompleted;

        event EventHandler<ContentTranslateEventArgs> ContentTranslateCompleted;

        IService AddCustomizedContentForm(string attributeName, Func<int, int, IAttributes, string> customized);

        event EventHandler<ContentFormSubmitedEventArgs> ContentFormSubmited;

        IService AddStlElementParser(string elementName, Func<IParseContext, string> parse);

        event EventHandler<ParseEventArgs> PreParse;

        event EventHandler<ParseEventArgs> PostParse;

        IService AddJsonGet(Func<IRequestContext, object> jsonGet);

        IService AddJsonGet(Func<IRequestContext, string, object> jsonGetWithName);

        IService AddJsonGet(Func<IRequestContext, string, string, object> jsonGetWithNameAndId);

        IService AddJsonPost(Func<IRequestContext, object> jsonPost);

        IService AddJsonPost(Func<IRequestContext, string, object> jsonPostWithName);

        IService AddJsonPost(Func<IRequestContext, string, string, object> jsonPostWithNameAndId);

        IService AddJsonPut(Func<IRequestContext, object> jsonPut);

        IService AddJsonPut(Func<IRequestContext, string, object> jsonPutWithName);

        IService AddJsonPut(Func<IRequestContext, string, string, object> jsonPutWithNameAndId);

        IService AddJsonDelete(Func<IRequestContext, object> jsonDelete);

        IService AddJsonDelete(Func<IRequestContext, string, object> jsonDeleteWithName);

        IService AddJsonDelete(Func<IRequestContext, string, string, object> jsonDeleteWithNameAndId);

        IService AddHttpGet(Func<IRequestContext, HttpResponseMessage> httpGet);

        IService AddHttpGet(Func<IRequestContext, string, HttpResponseMessage> httpGetWithName);

        IService AddHttpGet(Func<IRequestContext, string, string, HttpResponseMessage> httpGetWithNameAndId);

        IService AddHttpPost(Func<IRequestContext, HttpResponseMessage> httpPost);

        IService AddHttpPost(Func<IRequestContext, string, HttpResponseMessage> httpPostWithName);

        IService AddHttpPost(Func<IRequestContext, string, string, HttpResponseMessage> httpPostWithNameAndId);

        IService AddHttpPut(Func<IRequestContext, HttpResponseMessage> httpPut);

        IService AddHttpPut(Func<IRequestContext, string, HttpResponseMessage> httpPutWithName);

        IService AddHttpPut(Func<IRequestContext, string, string, HttpResponseMessage> httpPutWithNameAndId);

        IService AddHttpDelete(Func<IRequestContext, HttpResponseMessage> httpDelete);

        IService AddHttpDelete(Func<IRequestContext, string, HttpResponseMessage> httpDeleteWithName);

        IService AddHttpDelete(Func<IRequestContext, string, string, HttpResponseMessage> httpDeleteWithNameAndId);
    }
}
