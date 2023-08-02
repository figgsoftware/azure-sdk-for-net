// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary> A single, role-attributed message within a chat completion interaction. </summary>
    public partial class ChatMessage
    {
        /// <summary> Initializes a new instance of ChatMessage. </summary>
        /// <param name="role"> The role associated with this message payload. </param>
        /// <param name="content"> The text associated with this message payload. </param>
        public ChatMessage(ChatRole role, string content)
        {
            Role = role;
            Content = content;
        }

        /// <summary> Initializes a new instance of ChatMessage. </summary>
        /// <param name="role"> The role associated with this message payload. </param>
        /// <param name="content"> The text associated with this message payload. </param>
        /// <param name="name">
        /// The name of the author of this message. `name` is required if role is `function`, and it should be the name of the
        /// function whose response is in the `content`. May contain a-z, A-Z, 0-9, and underscores, with a maximum length of
        /// 64 characters.
        /// </param>
        /// <param name="functionCall"> The name and arguments of a function that should be called, as generated by the model. </param>
        internal ChatMessage(ChatRole role, string content, string name, FunctionCall functionCall)
        {
            Role = role;
            Content = content;
            Name = name;
            FunctionCall = functionCall;
        }

        /// <summary> The role associated with this message payload. </summary>
        public ChatRole Role { get; set; }
        /// <summary> The text associated with this message payload. </summary>
        public string Content { get; set; }
        /// <summary>
        /// The name of the author of this message. `name` is required if role is `function`, and it should be the name of the
        /// function whose response is in the `content`. May contain a-z, A-Z, 0-9, and underscores, with a maximum length of
        /// 64 characters.
        /// </summary>
        public string Name { get; set; }
        /// <summary> The name and arguments of a function that should be called, as generated by the model. </summary>
        public FunctionCall FunctionCall { get; set; }
    }
}
