using System.Threading.Tasks;

namespace SiteServer.Plugin
{
    /// <summary>
    /// The interface to be implemented by classes which represent a 'job' to be
    /// performed.
    /// </summary>
    /// <remarks>
    /// Instances of this interface must have a <see langword="public" />
    /// no-argument constructor. <see cref="T:Quartz.JobDataMap" /> provides a mechanism for 'instance member data'
    /// that may be required by some implementations of this interface.
    /// </remarks>
    /// <seealso cref="T:Quartz.IJobDetail" />
    /// <seealso cref="T:Quartz.JobBuilder" />
    /// <seealso cref="T:Quartz.DisallowConcurrentExecutionAttribute" />
    /// <seealso cref="T:Quartz.PersistJobDataAfterExecutionAttribute" />
    /// <seealso cref="T:Quartz.ITrigger" />
    /// <seealso cref="T:Quartz.IScheduler" />
    /// <author>James House</author>
    /// <author>Marko Lahma (.NET)</author>
    public interface IJob
    {
        /// <summary>
        /// Called by the <see cref="T:Quartz.IScheduler" /> when a <see cref="T:Quartz.ITrigger" />
        /// fires that is associated with the <see cref="T:Quartz.IJob" />.
        /// </summary>
        /// <remarks>
        /// The implementation may wish to set a  result object on the
        /// JobExecutionContext before this method exits.  The result itself
        /// is meaningless to Quartz, but may be informative to
        /// <see cref="T:Quartz.IJobListener" />s or
        /// <see cref="T:Quartz.ITriggerListener" />s that are watching the job's
        /// execution.
        /// </remarks>
        /// <param name="context">The execution context.</param>
        Task Execute(IJobExecutionContext context);
    }
}
