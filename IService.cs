using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public interface IService
    {
        event EventHandler<ContentEventArgs> ContentAddCompleted;

        event EventHandler<ContentEventArgs> ContentDeleteCompleted;

        event EventHandler<ContentTranslateEventArgs> ContentTranslateCompleted;

        event EventHandler<ContentFormSubmitEventArgs> ContentFormSubmit;

        event ContentFormLoadEventHandler ContentFormLoad;

        event EventHandler<ParseEventArgs> BeforeStlParse;

        event EventHandler<ParseEventArgs> AfterStlParse;

        IService AddPluginMenu(Menu menu);

        IService AddSiteMenu(Func<int, Menu> siteMenuFunc);

        IService AddContentModel(string tableName, List<TableColumn> tableColumns);

        IService AddDatabaseTable(string tableName, List<TableColumn> tableColumns);

        IService AddContentMenu(Menu menu);

        IService AddContentColumn(string columnName, Func<IContentContext, string> columnFunc);

        IService AddStlElementParser(string elementName, Func<IParseContext, string> parse);

        IService AddApiAuthorization();

        IService AddJob(string command, IJob job);

        event ApiEventHandler ApiGet;

        event ApiEventHandler ApiPost;

        event ApiEventHandler ApiPut;

        event ApiEventHandler ApiDelete;
    }
}
