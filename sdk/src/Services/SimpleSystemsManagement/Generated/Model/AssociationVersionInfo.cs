/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the association version.
    /// </summary>
    public partial class AssociationVersionInfo
    {
        private string _associationId;
        private string _associationName;
        private string _associationVersion;
        private AssociationComplianceSeverity _complianceSeverity;
        private DateTime? _createdDate;
        private string _documentVersion;
        private string _maxConcurrency;
        private string _maxErrors;
        private string _name;
        private InstanceAssociationOutputLocation _outputLocation;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private string _scheduleExpression;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID created by the system when the association was created.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationName. 
        /// <para>
        /// The name specified for the association version when the association version was created.
        /// </para>
        /// </summary>
        public string AssociationName
        {
            get { return this._associationName; }
            set { this._associationName = value; }
        }

        // Check to see if AssociationName property is set
        internal bool IsSetAssociationName()
        {
            return this._associationName != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationVersion. 
        /// <para>
        /// The association version.
        /// </para>
        /// </summary>
        public string AssociationVersion
        {
            get { return this._associationVersion; }
            set { this._associationVersion = value; }
        }

        // Check to see if AssociationVersion property is set
        internal bool IsSetAssociationVersion()
        {
            return this._associationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceSeverity. 
        /// <para>
        /// The severity level that is assigned to the association.
        /// </para>
        /// </summary>
        public AssociationComplianceSeverity ComplianceSeverity
        {
            get { return this._complianceSeverity; }
            set { this._complianceSeverity = value; }
        }

        // Check to see if ComplianceSeverity property is set
        internal bool IsSetComplianceSeverity()
        {
            return this._complianceSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the association version was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of a Systems Manager document used when the association version was created.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of targets allowed to run the association at the same time. You
        /// can specify a number, for example 10, or a percentage of the target set, for example
        /// 10%. The default value is 100%, which means all targets run the association at the
        /// same time.
        /// </para>
        ///  
        /// <para>
        /// If a new instance starts and attempts to run an association while Systems Manager
        /// is running MaxConcurrency associations, the association is allowed to run. During
        /// the next association interval, the new instance will process its association within
        /// the limit specified for MaxConcurrency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The number of errors that are allowed before the system stops sending requests to
        /// run the association on additional targets. You can specify either an absolute number
        /// of errors, for example 10, or a percentage of the target set, for example 10%. If
        /// you specify 3, for example, the system stops sending requests when the fourth error
        /// is received. If you specify 0, then the system stops sending requests after the first
        /// error is returned. If you run an association on 50 instances and set MaxError to 10%,
        /// then the system stops sending the request when the sixth error is received.
        /// </para>
        ///  
        /// <para>
        /// Executions that are already running an association when MaxErrors is reached are allowed
        /// to complete, but some of these executions may fail as well. If you need to ensure
        /// that there won't be more than max-errors failed executions, set MaxConcurrency to
        /// 1 so that executions proceed one at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxErrors
        {
            get { return this._maxErrors; }
            set { this._maxErrors = value; }
        }

        // Check to see if MaxErrors property is set
        internal bool IsSetMaxErrors()
        {
            return this._maxErrors != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name specified when the association was created.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The location in Amazon S3 specified for the association when the association version
        /// was created.
        /// </para>
        /// </summary>
        public InstanceAssociationOutputLocation OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Parameters specified when the association version was created.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The cron or rate schedule specified for the association when the association version
        /// was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets specified for the association when the association version was created.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}