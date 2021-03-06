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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// An action to be performed when the <code>condition</code> is TRUE.
    /// </summary>
    public partial class Action
    {
        private ClearTimerAction _clearTimer;
        private IotTopicPublishAction _iotTopicPublish;
        private ResetTimerAction _resetTimer;
        private SetTimerAction _setTimer;
        private SetVariableAction _setVariable;
        private SNSTopicPublishAction _sns;

        /// <summary>
        /// Gets and sets the property ClearTimer. 
        /// <para>
        /// Information needed to clear the timer.
        /// </para>
        /// </summary>
        public ClearTimerAction ClearTimer
        {
            get { return this._clearTimer; }
            set { this._clearTimer = value; }
        }

        // Check to see if ClearTimer property is set
        internal bool IsSetClearTimer()
        {
            return this._clearTimer != null;
        }

        /// <summary>
        /// Gets and sets the property IotTopicPublish. 
        /// <para>
        /// Publishes an MQTT message with the given topic to the AWS IoT Message Broker.
        /// </para>
        /// </summary>
        public IotTopicPublishAction IotTopicPublish
        {
            get { return this._iotTopicPublish; }
            set { this._iotTopicPublish = value; }
        }

        // Check to see if IotTopicPublish property is set
        internal bool IsSetIotTopicPublish()
        {
            return this._iotTopicPublish != null;
        }

        /// <summary>
        /// Gets and sets the property ResetTimer. 
        /// <para>
        /// Information needed to reset the timer.
        /// </para>
        /// </summary>
        public ResetTimerAction ResetTimer
        {
            get { return this._resetTimer; }
            set { this._resetTimer = value; }
        }

        // Check to see if ResetTimer property is set
        internal bool IsSetResetTimer()
        {
            return this._resetTimer != null;
        }

        /// <summary>
        /// Gets and sets the property SetTimer. 
        /// <para>
        /// Information needed to set the timer.
        /// </para>
        /// </summary>
        public SetTimerAction SetTimer
        {
            get { return this._setTimer; }
            set { this._setTimer = value; }
        }

        // Check to see if SetTimer property is set
        internal bool IsSetSetTimer()
        {
            return this._setTimer != null;
        }

        /// <summary>
        /// Gets and sets the property SetVariable. 
        /// <para>
        /// Sets a variable to a specified value.
        /// </para>
        /// </summary>
        public SetVariableAction SetVariable
        {
            get { return this._setVariable; }
            set { this._setVariable = value; }
        }

        // Check to see if SetVariable property is set
        internal bool IsSetSetVariable()
        {
            return this._setVariable != null;
        }

        /// <summary>
        /// Gets and sets the property Sns. 
        /// <para>
        /// Sends an Amazon SNS message.
        /// </para>
        /// </summary>
        public SNSTopicPublishAction Sns
        {
            get { return this._sns; }
            set { this._sns = value; }
        }

        // Check to see if Sns property is set
        internal bool IsSetSns()
        {
            return this._sns != null;
        }

    }
}