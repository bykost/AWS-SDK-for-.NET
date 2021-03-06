/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The GetBucketLoggingResponse contains the GetBucketLoggingResult and
    /// any headers returned by S3.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class GetBucketLoggingResponse : S3Response
    {
        #region Private Members

        private S3BucketLoggingConfig bucketLoggingConfig;

        #endregion

        #region BucketLoggingConfig

        /// <summary>
        /// Gets and sets the LoggingConfig property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketLoggingConfig")]
        public S3BucketLoggingConfig BucketLoggingConfig
        {
            get
            {
                if (this.bucketLoggingConfig == null)
                {
                    this.bucketLoggingConfig = new S3BucketLoggingConfig();
                }
                return this.bucketLoggingConfig;
            }
            set { this.bucketLoggingConfig = value; }
        }

        #endregion
    }
}