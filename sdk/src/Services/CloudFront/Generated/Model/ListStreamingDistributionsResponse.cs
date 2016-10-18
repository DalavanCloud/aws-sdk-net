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
 * Do not modify this file. This file is generated from the cloudfront-2016-09-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The returned result of the corresponding request.
    /// </summary>
    public partial class ListStreamingDistributionsResponse : AmazonWebServiceResponse
    {
        private StreamingDistributionList _streamingDistributionList;

        /// <summary>
        /// Gets and sets the property StreamingDistributionList. 
        /// <para>
        /// The <code>StreamingDistributionList</code> type. 
        /// </para>
        /// </summary>
        public StreamingDistributionList StreamingDistributionList
        {
            get { return this._streamingDistributionList; }
            set { this._streamingDistributionList = value; }
        }

        // Check to see if StreamingDistributionList property is set
        internal bool IsSetStreamingDistributionList()
        {
            return this._streamingDistributionList != null;
        }

    }
}