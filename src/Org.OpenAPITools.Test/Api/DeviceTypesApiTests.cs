/* 
 * Metacore IOT Object Storage API
 *
 * Metacore IOT Core Services
 *
 * The version of the OpenAPI document: 0.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing DeviceTypesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DeviceTypesApiTests : IDisposable
    {
        private DeviceTypesApi instance;

        public DeviceTypesApiTests()
        {
            instance = new DeviceTypesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeviceTypesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DeviceTypesApi
            //Assert.IsType(typeof(DeviceTypesApi), instance, "instance is a DeviceTypesApi");
        }

        
        /// <summary>
        /// Test GetdeviceTypes
        /// </summary>
        [Fact]
        public void GetdeviceTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //string sort = null;
            //int? page = null;
            //int? maxResults = null;
            //var response = instance.GetdeviceTypes(where, sort, page, maxResults);
            //Assert.IsType<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test GetdeviceTypesItem
        /// </summary>
        [Fact]
        public void GetdeviceTypesItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceTypesId = null;
            //var response = instance.GetdeviceTypesItem(deviceTypesId);
            //Assert.IsType<DeviceTypes> (response, "response is DeviceTypes");
        }
        
        /// <summary>
        /// Test PatchdeviceTypesItem
        /// </summary>
        [Fact]
        public void PatchdeviceTypesItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceTypesId = null;
            //string ifMatch = null;
            //DeviceTypes deviceTypes = null;
            //instance.PatchdeviceTypesItem(deviceTypesId, ifMatch, deviceTypes);
            
        }
        
        /// <summary>
        /// Test PostdeviceTypes
        /// </summary>
        [Fact]
        public void PostdeviceTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeviceTypes deviceTypes = null;
            //instance.PostdeviceTypes(deviceTypes);
            
        }
        
        /// <summary>
        /// Test PutdeviceTypesItem
        /// </summary>
        [Fact]
        public void PutdeviceTypesItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceTypesId = null;
            //string ifMatch = null;
            //DeviceTypes deviceTypes = null;
            //instance.PutdeviceTypesItem(deviceTypesId, ifMatch, deviceTypes);
            
        }
        
    }

}
