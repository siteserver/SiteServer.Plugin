using System.Threading.Tasks;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 由表示要执行的任务的类实现的接口。
    /// 实现此接口的插件将用于SiteServer Cli命令行中。
    /// </summary>
    /// <remarks>
    /// 这个接口的实例必须有一个无参数的构造函数。
    /// </remarks>
    public interface IJob
    {
        /// <summary>
        /// 由SiteServer Cli命令行执行此命令。
        /// </summary>
        /// <param name="context">命令执行上下文。</param>
        Task Execute(IJobExecutionContext context);
    }
}
