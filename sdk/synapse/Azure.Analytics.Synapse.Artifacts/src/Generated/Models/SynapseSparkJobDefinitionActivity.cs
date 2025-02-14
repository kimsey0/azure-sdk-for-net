// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execute spark job activity. </summary>
    public partial class SynapseSparkJobDefinitionActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of SynapseSparkJobDefinitionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="sparkJob"> Synapse spark job reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="sparkJob"/> is null. </exception>
        public SynapseSparkJobDefinitionActivity(string name, SynapseSparkJobReference sparkJob) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(sparkJob, nameof(sparkJob));

            SparkJob = sparkJob;
            Arguments = new ChangeTrackingList<object>();
            Files = new ChangeTrackingList<object>();
            Type = "SparkJob";
        }

        /// <summary> Initializes a new instance of SynapseSparkJobDefinitionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="sparkJob"> Synapse spark job reference. </param>
        /// <param name="arguments"> User specified arguments to SynapseSparkJobDefinitionActivity. </param>
        /// <param name="file"> The main file used for the job, which will override the &apos;file&apos; of the spark job definition you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="className"> The fully-qualified identifier or the main class that is in the main definition file, which will override the &apos;className&apos; of the spark job definition you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="files"> Additional files used for reference in the main definition file, which will override the &apos;files&apos; of the spark job definition you provide. </param>
        /// <param name="targetBigDataPool"> The name of the big data pool which will be used to execute the spark batch job, which will override the &apos;targetBigDataPool&apos; of the spark job definition you provide. </param>
        /// <param name="executorSize"> Number of core and memory to be used for executors allocated in the specified Spark pool for the job, which will be used for overriding &apos;executorCores&apos; and &apos;executorMemory&apos; of the spark job definition you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="conf"> Spark configuration properties, which will override the &apos;conf&apos; of the spark job definition you provide. </param>
        /// <param name="driverSize"> Number of core and memory to be used for driver allocated in the specified Spark pool for the job, which will be used for overriding &apos;driverCores&apos; and &apos;driverMemory&apos; of the spark job definition you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="numExecutors"> Number of executors to launch for this job, which will override the &apos;numExecutors&apos; of the spark job definition you provide. </param>
        internal SynapseSparkJobDefinitionActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, SynapseSparkJobReference sparkJob, IList<object> arguments, object file, object className, IList<object> files, BigDataPoolParametrizationReference targetBigDataPool, object executorSize, object conf, object driverSize, int? numExecutors) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            SparkJob = sparkJob;
            Arguments = arguments;
            File = file;
            ClassName = className;
            Files = files;
            TargetBigDataPool = targetBigDataPool;
            ExecutorSize = executorSize;
            Conf = conf;
            DriverSize = driverSize;
            NumExecutors = numExecutors;
            Type = type ?? "SparkJob";
        }

        /// <summary> Synapse spark job reference. </summary>
        public SynapseSparkJobReference SparkJob { get; set; }
        /// <summary> User specified arguments to SynapseSparkJobDefinitionActivity. </summary>
        public IList<object> Arguments { get; }
        /// <summary> The main file used for the job, which will override the &apos;file&apos; of the spark job definition you provide. Type: string (or Expression with resultType string). </summary>
        public object File { get; set; }
        /// <summary> The fully-qualified identifier or the main class that is in the main definition file, which will override the &apos;className&apos; of the spark job definition you provide. Type: string (or Expression with resultType string). </summary>
        public object ClassName { get; set; }
        /// <summary> Additional files used for reference in the main definition file, which will override the &apos;files&apos; of the spark job definition you provide. </summary>
        public IList<object> Files { get; }
        /// <summary> The name of the big data pool which will be used to execute the spark batch job, which will override the &apos;targetBigDataPool&apos; of the spark job definition you provide. </summary>
        public BigDataPoolParametrizationReference TargetBigDataPool { get; set; }
        /// <summary> Number of core and memory to be used for executors allocated in the specified Spark pool for the job, which will be used for overriding &apos;executorCores&apos; and &apos;executorMemory&apos; of the spark job definition you provide. Type: string (or Expression with resultType string). </summary>
        public object ExecutorSize { get; set; }
        /// <summary> Spark configuration properties, which will override the &apos;conf&apos; of the spark job definition you provide. </summary>
        public object Conf { get; set; }
        /// <summary> Number of core and memory to be used for driver allocated in the specified Spark pool for the job, which will be used for overriding &apos;driverCores&apos; and &apos;driverMemory&apos; of the spark job definition you provide. Type: string (or Expression with resultType string). </summary>
        public object DriverSize { get; set; }
        /// <summary> Number of executors to launch for this job, which will override the &apos;numExecutors&apos; of the spark job definition you provide. </summary>
        public int? NumExecutors { get; set; }
    }
}
