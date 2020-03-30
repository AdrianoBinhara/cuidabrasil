/*
 * Floripa vrs Corona - Phonebook
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
 
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ContactApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("//phonebook/contacts")]
        [ValidateModelState]
        [SwaggerOperation("PhonebookContactsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Contact>), description: "successful operation")]
        public virtual IActionResult PhonebookContactsGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Contact>));

            string exampleJson = null;
            exampleJson = "[ {\n  \"journal\" : [ null, null ],\n  \"phone\" : \"phone\",\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"age\" : 0\n}, {\n  \"journal\" : [ null, null ],\n  \"phone\" : \"phone\",\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"age\" : 0\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Contact>>(exampleJson)
            : default(List<Contact>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id1"></param>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("//phonebook/contacts/id/{id1}")]
        [ValidateModelState]
        [SwaggerOperation("PhonebookContactsIdId1Get")]
        [SwaggerResponse(statusCode: 200, type: typeof(Contact), description: "successful operation")]
        public virtual IActionResult PhonebookContactsIdId1Get([FromRoute][Required]string id1)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Contact));

            string exampleJson = null;
            exampleJson = "{\n  \"journal\" : [ null, null ],\n  \"phone\" : \"phone\",\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"age\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Contact>(exampleJson)
            : default(Contact);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="200">successful operation</response>
        [HttpPatch]
        [Route("//phonebook/contacts")]
        [ValidateModelState]
        [SwaggerOperation("PhonebookContactsPatch")]
        [SwaggerResponse(statusCode: 200, type: typeof(Contact), description: "successful operation")]
        public virtual IActionResult PhonebookContactsPatch([FromBody]Body2 body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Contact));

            string exampleJson = null;
            exampleJson = "{\n  \"journal\" : [ null, null ],\n  \"phone\" : \"phone\",\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"age\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Contact>(exampleJson)
            : default(Contact);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="200">successful operation</response>
        [HttpPost]
        [Route("//phonebook/contacts")]
        [ValidateModelState]
        [SwaggerOperation("PhonebookContactsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Contact), description: "successful operation")]
        public virtual IActionResult PhonebookContactsPost([FromBody]Body1 body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Contact));

            string exampleJson = null;
            exampleJson = "{\n  \"journal\" : [ null, null ],\n  \"phone\" : \"phone\",\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"age\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Contact>(exampleJson)
            : default(Contact);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="200">successful operation</response>
        [HttpPut]
        [Route("//phonebook/contacts")]
        [ValidateModelState]
        [SwaggerOperation("PhonebookContactsPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Contact), description: "successful operation")]
        public virtual IActionResult PhonebookContactsPut([FromBody]Body body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Contact));

            string exampleJson = null;
            exampleJson = "{\n  \"journal\" : [ null, null ],\n  \"phone\" : \"phone\",\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"age\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Contact>(exampleJson)
            : default(Contact);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
