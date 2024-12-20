// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Inference
{
    /// <summary> A request chat message representing response or action from the assistant. </summary>
    public partial class ChatRequestAssistantMessage : ChatRequestMessage
    {
        /// <summary> Initializes a new instance of <see cref="ChatRequestAssistantMessage"/>. </summary>
        /// <param name="role"> The chat role associated with this message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="content"> The content of the message. </param>
        /// <param name="toolCalls">
        /// The tool calls that must be resolved and have their outputs appended to subsequent input messages for the chat
        /// completions request to resolve as configured.
        /// </param>
        internal ChatRequestAssistantMessage(ChatRole role, IDictionary<string, BinaryData> serializedAdditionalRawData, string content, IList<ChatCompletionsToolCall> toolCalls) : base(role, serializedAdditionalRawData)
        {
            Content = content;
            ToolCalls = toolCalls;
        }

        /// <summary> The content of the message. </summary>
        public string Content { get; set; }
    }
}
