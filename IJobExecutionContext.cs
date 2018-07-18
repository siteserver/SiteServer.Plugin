using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// A context bundle containing handles to various environment information, that
    /// is given to a <see cref="P:Quartz.IJobExecutionContext.JobDetail" /> instance as it is
    /// executed, and to a <see cref="T:Quartz.ITrigger" /> instance after the
    /// execution completes.
    /// </summary>
    public interface IJobExecutionContext
    {
        string Command { get; }

        string[] Args { get; }

        /// <summary>
        /// Get the instance of the <see cref="T:Quartz.IJob" /> that was created for this
        /// execution.
        /// <para>
        /// Note: The Job instance is not available through remote scheduler
        /// interfaces.
        /// </para>
        /// </summary>
        IJob JobInstance { get; }
        /// <summary>
        /// The actual time the trigger fired. For instance the scheduled time may
        /// have been 10:00:00 but the actual fire time may have been 10:00:03 if
        /// the scheduler was too busy.
        /// </summary>
        /// <returns> Returns the fireTimeUtc.</returns>
        /// <seealso cref="P:Quartz.IJobExecutionContext.ScheduledFireTimeUtc" />
        DateTime FireTime { get; }
        /// <summary>
        /// The scheduled time the trigger fired for. For instance the scheduled
        /// time may have been 10:00:00 but the actual fire time may have been
        /// 10:00:03 if the scheduler was too busy.
        /// </summary>
        /// <returns> Returns the scheduledFireTimeUtc.</returns>
        /// <seealso cref="P:Quartz.IJobExecutionContext.FireTimeUtc" />
        DateTime? ScheduledFireTime { get; }
        /// <summary>Gets the previous fire time.</summary>
        /// <value>The previous fire time.</value>
        DateTime? PreviousFireTime { get; }
        /// <summary>Gets the next fire time.</summary>
        /// <value>The next fire time.</value>
        DateTime? NextFireTime { get; }

        /// <summary>
        /// The amount of time the job ran for.  The returned
        /// value will be <see cref="F:System.TimeSpan.MinValue" /> until the job has actually completed (or thrown an
        /// exception), and is therefore generally only useful to
        /// <see cref="T:Quartz.IJobListener" />s and <see cref="T:Quartz.ITriggerListener" />s.
        /// </summary>
        TimeSpan JobRunTime { get; }
    }
}