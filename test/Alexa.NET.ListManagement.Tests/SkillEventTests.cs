using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alexa.NET.ListManagement.SkillEvents;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Xunit;

namespace Alexa.NET.ListManagement.Tests
{
    public class SkillEventTests
    {
        private const string TestListId = "09d9d7df-05be-438c-veba-9d32968b4509";
        private const string TestListItemId = "520a9f98-8e73-4fb8-veba-bfb6576cf623";

        public SkillEventTests()
        {
           RequestConverter.RequestConverters.Add(new ListSkillEventRequestTypeConverter());
        }

        [Fact]
        public void ListItemCreatedRequestDeserializesCorrectly()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("ListItemCreatedRequest.json");
            Assert.IsType<ListSkillItemCreatedRequest>(request.Request);

            var skillRequest = (ListSkillItemCreatedRequest) request.Request;

            Assert.Equal(TestListId,skillRequest.Body.ListId);
            Assert.Single(skillRequest.Body.ListItemIds);
            Assert.Equal(TestListItemId,skillRequest.Body.ListItemIds.First());
        }

        [Fact]
        public void ListItemUpdatedRequestDeserializesCorrectly()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("ListItemUpdatedRequest.json");
            Assert.IsType<ListSkillItemUpdatedRequest>(request.Request);

            var skillRequest = (ListSkillItemUpdatedRequest) request.Request;
            Assert.Equal(TestListId,skillRequest.Body.ListId);
            Assert.Single(skillRequest.Body.ListItemIds);
            Assert.Equal(TestListItemId, skillRequest.Body.ListItemIds.First());
        }


        [Fact]
        public void ListItemDeletedRequestDeserializesCorrectly()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("ListItemDeletedRequest.json");
            Assert.IsType<ListSkillItemDeletedRequest>(request.Request);

            var skillRequest = (ListSkillItemDeletedRequest)request.Request;
            Assert.Equal(TestListId, skillRequest.Body.ListId);
        }

        [Fact]
        public void ListCreatedRequestDeserializesCorrectly()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("ListCreatedRequest.json");
            Assert.IsType<ListSkillListCreatedRequest>(request.Request);

            var skillRequest = (ListSkillListCreatedRequest)request.Request;
            Assert.Equal(TestListId, skillRequest.Body.ListId);
        }

        [Fact]
        public void ListUpdatedRequestDeserializesCorrectly()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("ListUpdatedRequest.json");
            Assert.IsType<ListSkillListUpdatedRequest>(request.Request);

            var skillRequest = (ListSkillListUpdatedRequest)request.Request;
            Assert.Equal(TestListId, skillRequest.Body.ListId);
        }

        [Fact]
        public void ListDeletedRequestDeserializesCorrectly()
        {
            var request = Utility.ExampleFileContent<SkillRequest>("ListDeletedRequest.json");
            Assert.IsType<ListSkillListDeletedRequest>(request.Request);

            var skillRequest = (ListSkillListDeletedRequest)request.Request;
            Assert.Equal(TestListId, skillRequest.Body.ListId);
        }
    }
}
