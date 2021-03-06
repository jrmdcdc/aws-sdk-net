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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCampaign operation.
    /// Use to update a campaign.
    /// </summary>
    public partial class UpdateCampaignRequest : AmazonPinpointRequest
    {
        private string _applicationId;
        private string _campaignId;
        private WriteCampaignRequest _writeCampaignRequest;

        /// <summary>
        /// Gets and sets the property ApplicationId. The unique ID of your Amazon Pinpoint application.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CampaignId. The unique ID of the campaign.
        /// </summary>
        [AWSProperty(Required=true)]
        public string CampaignId
        {
            get { return this._campaignId; }
            set { this._campaignId = value; }
        }

        // Check to see if CampaignId property is set
        internal bool IsSetCampaignId()
        {
            return this._campaignId != null;
        }

        /// <summary>
        /// Gets and sets the property WriteCampaignRequest.
        /// </summary>
        [AWSProperty(Required=true)]
        public WriteCampaignRequest WriteCampaignRequest
        {
            get { return this._writeCampaignRequest; }
            set { this._writeCampaignRequest = value; }
        }

        // Check to see if WriteCampaignRequest property is set
        internal bool IsSetWriteCampaignRequest()
        {
            return this._writeCampaignRequest != null;
        }

    }
}