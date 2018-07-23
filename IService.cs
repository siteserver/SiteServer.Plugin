using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        /// <summary>
        /// 添加SiteServer Cli命令行可以执行的任务。
        /// 实现此方法的插件将能够在SiteServer Cli命令行中运行任务。
        /// </summary>
        /// <param name="command"></param>
        /// <param name="job"></param>
        /// <returns></returns>
        IService AddJob(string command, Func<IJobContext, Task> job);

        event ApiEventHandler ApiGet;

        event ApiEventHandler ApiPost;

        event ApiEventHandler ApiPut;

        event ApiEventHandler ApiDelete;
    }
}
