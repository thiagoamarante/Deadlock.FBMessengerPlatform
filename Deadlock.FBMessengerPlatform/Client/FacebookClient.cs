using Deadlock.FBMessengerPlatform.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public class FacebookClient : Facebook.FacebookClient, IDisposable
    {
        public FacebookClient()
            :base()
        {
            this.SetJsonSerializers();
        }

        public FacebookClient(string accessToken)
            :base(accessToken)
        {
            this.SetJsonSerializers();
        }

        #region Properties
        public JsonSerializerSettings JsonSerializerSettings { get; set; } = new JsonSerializerSettings();
        #endregion

        #region Methods

        public async Task<Result> SetMessengerProfile(MessengerProfile messengerProfile)
        {
            Result result = new Result();
            try
            {
                JObject returnValue = null;
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (!string.IsNullOrEmpty(messengerProfile.AccountLinkingUrl))
                    parameters["account_linking_url"] = messengerProfile.AccountLinkingUrl;
                if (messengerProfile.GetStarted != null)
                    parameters["get_started"] = messengerProfile.GetStarted;
                if (messengerProfile.PersistentMenu != null)
                    parameters["persistent_menu"] = messengerProfile.PersistentMenu;
                if (messengerProfile.Greeting != null)
                    parameters["greeting"] = messengerProfile.Greeting;

                returnValue = (JObject)await this.PostTaskAsync("me/messenger_profile", parameters);
                result.Error = this.CreateResultError(returnValue);
                if (result.Error == null)
                {
                    result.Message = returnValue.Value<string>("result");
                    result.Success = result.Message.Contains("success");
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// You can set a greeting for new conversations. This can be used to communicate your bot's functionality. If the greeting text is not set, the page description will be shown in the welcome screen. You can personalize the text with the person's name.
        /// </summary>
        /// <param name="text">
        /// Must be UTF-8 and has a 160 character limit
        /// You can personalize the greeting text using the person's name. You can use the following template strings: {{user_first_name}}, {{user_last_name}}, {{user_full_name}}
        /// </param>
        /// <returns></returns>
        public async Task<Result> SetGreetingText(string text = null)
        {
            Result result = new Result();
            try
            {
                JObject returnValue = null;
                if (!string.IsNullOrEmpty(text))
                {
                    returnValue = (JObject)await this.PostTaskAsync("me/thread_settings", new
                    {
                        setting_type = "greeting",
                        greeting = new
                        {
                            text = text
                        }
                    });
                }
                else
                {
                    returnValue = (JObject)await this.DeleteTaskAsync("me/thread_settings", new
                    {
                        setting_type = "greeting"
                    }, new System.Threading.CancellationToken());
                }
                result.Error = this.CreateResultError(returnValue);
                if (result.Error == null)
                {
                    result.Message = returnValue.Value<string>("result");
                    result.Success = result.Message.Contains("Successfully");
                }
            }
            catch(Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// The Welcome Screen can display a Get Started button. When this button is tapped, we will trigger the postback received callback and deliver the person's page-scoped ID (PSID). You can then present a personalized message to greet the user or present buttons to prompt him or her to take an action.
        /// There are certain conditions to seeing the Welcome Screen and the Get Started button:
        /// They are only rendered the first time the user interacts with a the Page on Messenger.
        /// Only admins/developers/testers of the app can see it when the app is in development mode.
        /// Your app must be subscribed to postbacks on your webhook.
        /// </summary>
        /// <param name="payload">This data will be sent back to you via webhook.</param>
        /// <returns>
        /// A user tapping the Get Started button triggers the postback received callback.
        /// </returns>
        public async Task<Result> SetGetStartedButton(string payload = null)
        {
            Result result = new Result();
            try
            {
                JObject returnValue = null;
                if (!string.IsNullOrEmpty(payload))
                {
                    returnValue = (JObject)await this.PostTaskAsync("me/thread_settings", new
                    {
                        setting_type = "call_to_actions",
                        thread_state = "new_thread",
                        call_to_actions = new []
                        {
                            new { payload = payload }
                        }
                    });
                }
                else
                {
                    returnValue = (JObject)await this.DeleteTaskAsync("me/thread_settings", new
                    {
                        setting_type = "call_to_actions",
                        thread_state = "new_thread"
                    }, new System.Threading.CancellationToken());
                }
                result.Error = this.CreateResultError(returnValue);
                if (result.Error == null)
                {
                    result.Message = returnValue.Value<string>("result");
                    result.Success = result.Message.Contains("Successfully");
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// The Persistent Menu is a menu that is always available to the user. This menu should contain top-level actions that users can enact at any point. Having a persistent menu easily communicates the basic capabilities of your bot for first-time and returning users.
        /// The menu can be invoked by a user, by tapping on the 3-caret icon on the left of the composer.
        /// Menus are loaded from cache but updates are fetched each time they're loaded. If you update the menu, trigger the fetch by loading it and then load it again to see your changes.
        /// </summary>
        /// <param name="menuItems">call_to_actions is limited to 5</param>
        /// <returns></returns>
        public async Task<Result> SetPersistentMenu(List<MenuItem> menuItems = null)
        {
            Result result = new Result();
            try
            {
                JObject returnValue = null;
                if (menuItems != null)
                {
                    returnValue = (JObject)await this.PostTaskAsync("me/thread_settings", new
                    {
                        setting_type = "call_to_actions",
                        thread_state = "existing_thread",
                        call_to_actions = menuItems
                    });
                }
                else
                {
                    returnValue = (JObject)await this.DeleteTaskAsync("me/thread_settings", new
                    {
                        setting_type = "call_to_actions",
                        thread_state = "existing_thread"
                    }, new System.Threading.CancellationToken());
                }
                result.Error = this.CreateResultError(returnValue);
                if (result.Error == null)
                {
                    result.Message = returnValue.Value<string>("result");
                    result.Success = result.Message.Contains("Successfully");
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Set typing indicators or send read receipts using the Send API, to let users know you are processing their request.
        /// Typing indicators are automatically turned off after 20 seconds
        /// </summary>
        /// <param name="userId">User identification</param>
        /// <param name="action"></param>
        /// <returns></returns>
        public async Task<Result> SendAction(string userId, SenderAction action)
        {
            Result result = new Result();
            try
            {
                JObject returnValue = (JObject)await this.PostTaskAsync("me/messages", new
                {
                    recipient = new
                    {
                        id = userId
                    },
                    sender_action = action.GetJsonPropertyName()
                });
                result.Error = this.CreateResultError(returnValue);
                if(result.Error == null)
                {
                    result.Message = returnValue.Value<string>("recipient_id");
                    result.Success = true;
                }   
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Subscribe an app to get updates for a page. You can do this in the Webhooks section under the Messenger Tab.
        /// </summary>
        /// <returns></returns>
        public async Task<Result> SubscribedApps()
        {
            Result result = new Result();
            try
            {
                JObject returnValue = (JObject)await this.PostTaskAsync("me/subscribed_apps", null);
                result.Error = this.CreateResultError(returnValue);
                if (result.Error == null)
                {
                    result.Success = true;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Send messages to users.
        /// </summary>
        /// <param name="userId">User identification</param>
        /// <param name="message">Message object</param>
        /// <param name="notificationType">Push notification type: REGULAR, SILENT_PUSH, NO_PUSH</param>
        /// <returns></returns>
        public async Task<MessageResult> SendMessage(string userId, MessageSent message, NotificationType notificationType = NotificationType.Regular)
        {
            MessageResult result = new MessageResult();
            try
            {    
                JObject returnValue = (JObject)await this.PostTaskAsync("me/messages", new
                {
                    recipient = new
                    {
                        id = userId
                    },
                    notification_type = notificationType.GetJsonPropertyName(),
                    message = message
                });
                result.Error = this.CreateResultError(returnValue);
                if (result.Error == null)
                {
                    result.RecipientId = returnValue.Value<string>("recipient_id");
                    result.MessageId = returnValue.Value<string>("message_id");
                    result.AttachmentId = returnValue.Value<string>("attachment_id");
                    result.Success = true;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// The profile API can be used to query more information about the user, and personalize the experience further. This API is only available after the user initiated the conversation by sending a message or by interacting with a Web Plugin.
        /// </summary>
        /// <param name="userId">User identification</param>
        /// <returns></returns>
        public async Task<UserProfile> GetUserProfile(string userId)
        {
            return await this.GetTaskAsync<UserProfile>($"{userId}?fields=first_name,last_name,profile_pic,locale,timezone,gender,is_payment_enabled");
        }

        public void Dispose()
        {

        }
        #endregion

        #region Methods Private
        private void SetJsonSerializers()
        {
            this.SetJsonSerializers((obj) =>
            {
                string value = JsonConvert.SerializeObject(obj, this.JsonSerializerSettings);
                return value;
            }, (value, type) =>
            {
                return type == null? JsonConvert.DeserializeObject(value, this.JsonSerializerSettings) : JsonConvert.DeserializeObject(value, type, this.JsonSerializerSettings);
            });
        }

        private ResultError CreateResultError(JObject value)
        {
            ResultError result = null;
            if (value.Property("error") != null)
            {
                JObject error = (JObject)value.Property("error").Value;
                result = new ResultError()
                {
                    Message = error.Value<string>("message"),
                    Code = error.Value<int>("code"),
                    ErrorSubcode = error.Value<int>("error_subcode"),
                    FBTraceId = error.Value<string>("fbtrace_id"),
                    Type = error.Value<string>("type")
                };
            }
            return result;
        }
        #endregion
    }
}
