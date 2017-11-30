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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNotebookInstance operation.
    /// Deletes an Amazon SageMaker notebook instance. Before you can delete a notebook instance,
    /// you must call the <code>StopNotebookInstance</code> API. 
    /// 
    ///  <important> 
    /// <para>
    /// When you delete a notebook instance, you lose all of your data. Amazon SageMaker removes
    /// the ML compute instance, and deletes the ML storage volume and the network interface
    /// associated with the notebook instance. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteNotebookInstanceRequest : AmazonSageMakerRequest
    {
        private string _notebookInstanceName;

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        /// The name of the Amazon SageMaker notebook instance to delete.
        /// </para>
        /// </summary>
        public string NotebookInstanceName
        {
            get { return this._notebookInstanceName; }
            set { this._notebookInstanceName = value; }
        }

        // Check to see if NotebookInstanceName property is set
        internal bool IsSetNotebookInstanceName()
        {
            return this._notebookInstanceName != null;
        }

    }
}