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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeCommit
{

    /// <summary>
    /// Constants used for properties of type OrderEnum.
    /// </summary>
    public class OrderEnum : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for OrderEnum
        /// </summary>
        public static readonly OrderEnum Ascending = new OrderEnum("ascending");
        /// <summary>
        /// Constant Descending for OrderEnum
        /// </summary>
        public static readonly OrderEnum Descending = new OrderEnum("descending");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OrderEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderEnum FindValue(string value)
        {
            return FindValue<OrderEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortByEnum.
    /// </summary>
    public class SortByEnum : ConstantClass
    {

        /// <summary>
        /// Constant LastModifiedDate for SortByEnum
        /// </summary>
        public static readonly SortByEnum LastModifiedDate = new SortByEnum("lastModifiedDate");
        /// <summary>
        /// Constant RepositoryName for SortByEnum
        /// </summary>
        public static readonly SortByEnum RepositoryName = new SortByEnum("repositoryName");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SortByEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortByEnum FindValue(string value)
        {
            return FindValue<SortByEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortByEnum(string value)
        {
            return FindValue(value);
        }
    }

}