// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IpamPool usage information. </summary>
    public partial class IpamPoolUsage
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IpamPoolUsage"/>. </summary>
        internal IpamPoolUsage()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
            ChildPools = new ChangeTrackingList<IpamResourceBasics>();
            AllocatedAddressPrefixes = new ChangeTrackingList<string>();
            ReservedAddressPrefixes = new ChangeTrackingList<string>();
            AvailableAddressPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IpamPoolUsage"/>. </summary>
        /// <param name="addressPrefixes"> List of IP address prefixes of the resource. </param>
        /// <param name="childPools"> List of IpamPool that are children of this IpamPool. </param>
        /// <param name="allocatedAddressPrefixes"> List of assigned IP address prefixes. </param>
        /// <param name="reservedAddressPrefixes"> List of reserved IP address prefixes. These IP addresses could be reclaimed if not assigned in the given time. </param>
        /// <param name="availableAddressPrefixes"> List of available IP address prefixes. </param>
        /// <param name="totalNumberOfIPAddresses"> Total number of IP addresses managed in the IpamPool. </param>
        /// <param name="numberOfAllocatedIPAddresses"> Total number of assigned IP addresses in the IpamPool. </param>
        /// <param name="numberOfReservedIPAddresses"> Total number of reserved IP addresses in the IpamPool. </param>
        /// <param name="numberOfAvailableIPAddresses"> Total number of available IP addresses in the IpamPool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IpamPoolUsage(IReadOnlyList<string> addressPrefixes, IReadOnlyList<IpamResourceBasics> childPools, IReadOnlyList<string> allocatedAddressPrefixes, IReadOnlyList<string> reservedAddressPrefixes, IReadOnlyList<string> availableAddressPrefixes, string totalNumberOfIPAddresses, string numberOfAllocatedIPAddresses, string numberOfReservedIPAddresses, string numberOfAvailableIPAddresses, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AddressPrefixes = addressPrefixes;
            ChildPools = childPools;
            AllocatedAddressPrefixes = allocatedAddressPrefixes;
            ReservedAddressPrefixes = reservedAddressPrefixes;
            AvailableAddressPrefixes = availableAddressPrefixes;
            TotalNumberOfIPAddresses = totalNumberOfIPAddresses;
            NumberOfAllocatedIPAddresses = numberOfAllocatedIPAddresses;
            NumberOfReservedIPAddresses = numberOfReservedIPAddresses;
            NumberOfAvailableIPAddresses = numberOfAvailableIPAddresses;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of IP address prefixes of the resource. </summary>
        public IReadOnlyList<string> AddressPrefixes { get; }
        /// <summary> List of IpamPool that are children of this IpamPool. </summary>
        public IReadOnlyList<IpamResourceBasics> ChildPools { get; }
        /// <summary> List of assigned IP address prefixes. </summary>
        public IReadOnlyList<string> AllocatedAddressPrefixes { get; }
        /// <summary> List of reserved IP address prefixes. These IP addresses could be reclaimed if not assigned in the given time. </summary>
        public IReadOnlyList<string> ReservedAddressPrefixes { get; }
        /// <summary> List of available IP address prefixes. </summary>
        public IReadOnlyList<string> AvailableAddressPrefixes { get; }
        /// <summary> Total number of IP addresses managed in the IpamPool. </summary>
        public string TotalNumberOfIPAddresses { get; }
        /// <summary> Total number of assigned IP addresses in the IpamPool. </summary>
        public string NumberOfAllocatedIPAddresses { get; }
        /// <summary> Total number of reserved IP addresses in the IpamPool. </summary>
        public string NumberOfReservedIPAddresses { get; }
        /// <summary> Total number of available IP addresses in the IpamPool. </summary>
        public string NumberOfAvailableIPAddresses { get; }
    }
}
