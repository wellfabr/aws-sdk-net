/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The output for a ListStackResources action.</para>
    /// </summary>
    public partial class ListStackResourcesResult : AmazonWebServiceResponse
    {
        
        private List<StackResourceSummary> stackResourceSummaries = new List<StackResourceSummary>();
        private string nextToken;


        /// <summary>
        /// A list of <c>StackResourceSummary</c> structures.
        ///  
        /// </summary>
        public List<StackResourceSummary> StackResourceSummaries
        {
            get { return this.stackResourceSummaries; }
            set { this.stackResourceSummaries = value; }
        }

        // Check to see if StackResourceSummaries property is set
        internal bool IsSetStackResourceSummaries()
        {
            return this.stackResourceSummaries.Count > 0;
        }

        /// <summary>
        /// String that identifies the start of the next list of events, if there is one.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
