# Deadlock.FBMessengerPlatform (1.0.0)

Framework in C # to create bots for Facebook Messenger Platform

See how your bot can use our platform to have rich conversations with people on Messenger

> Messenger Platform
Introducing new tools to help you build your bot and reach 900 million people around the world

[More Details About Messenger Platform](https://developers.facebook.com/docs/messenger-platform) 

## Features
      
* WebHooks Verification
* WebHooks Post
* Get User Profile
* Set Welcome Message
* Send Basic Message
* Send Image Message
* Send Button Message
* Send Generic Message
* Send Receipt Message

## Creating Controller for WebHook
```c#
    using System.Net.Http;   
    using Deadlock.FBMessengerPlatform.WebHooks;

    public class FacebookController : Deadlock.FBMessengerPlatform.WebHooks.WebHooksController
    {
    }
```

### WebHook Verification

```c#
    using System.Net.Http;   
    using Deadlock.FBMessengerPlatform.WebHooks;

    public override HttpResponseMessage Get([System.Web.Http.FromUriAttribute] Hub hub)
    {
        //Add in appSettings <add key="Deadlock.FBMessengerPlatform.VerifyToken" value="{VerifyToken}" />
        return base.Get(hub);
    }
```

### WebHook Post

```c#
    using System.Net.Http;   
    using Deadlock.FBMessengerPlatform.WebHooks;

    public override HttpResponseMessage Post([System.Web.Http.FromBodyAttribute] Callback value)
    {
        //Implementation
        foreach(Entry entry in value.Entry)
        {
            foreach(Messaging messaging in entry.Messaging)
            {
                if(messaging.Delivery != null)
                {
                    //Confirmation Delivery
                }
                else if (messaging.Message != null)
                {
                    //User Send Message
                }
                else if (messaging.Optin != null)
                {
                    //User Call "Message Us" 
                }
                else if (messaging.PostBack != null)
                {
                    //User Button Click PostBack
                }
            }
        }
        return base.Post(value);
    }
```

### User Profile

```c#
    using Facebook;
    using Deadlock.FBMessengerPlatform.Client;

    static async Task UserProfile()
    {
        FacebookClient client = new FacebookClient(_config.PageAccessToken);
        var userProfile = await client.UserProfile("{userid}");
        Console.WriteLine(userProfile.first_name);
        Console.WriteLine(userProfile.last_name);
        Console.WriteLine(userProfile.profile_pic);
    }
```

### Set Welcome Message

```c#
    using Facebook;
    using Deadlock.FBMessengerPlatform.Client;

    static async Task SetWelcomeMessage()
    {
        FacebookClient client = new FacebookClient(_config.PageAccessToken);
        var result = await client.WelcomeMessage(new ThreadSettings()
        {
            call_to_actions = new List<CallToAction>()
            {
                new CallToAction()
                {
                    message = new Deadlock.FBMessengerPlatform.Client.Message()
                    {
                        attachment = new Attachment()
                        {
                            type = "template",
                            payload = new GenericPayloadTemplate()
                            {
                                elements = new List<GenericElement>()
                                {
                                    new GenericElement()
                                    {
                                        title = "Welcome to My Company!",
                                        item_url = "https://www.petersbowlerhats.com",
                                        image_url = "https://www.petersbowlerhats.com/img/hat.jpeg",
                                        subtitle = "We have the right hat for everyone.",
                                        buttons = new List<Button>()
                                        {
                                            new Button()
                                            {
                                                type = "web_url",
                                                url = "https://www.petersbowlerhats.com",
                                                title = "View Website"
                                            },
                                            new Button()
                                            {
                                                type = "postback",
                                                payload = "DEVELOPER_DEFINED_PAYLOAD",
                                                title = "Start Chatting"
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        });
    }
```

### Send Basic Message

```c#
    using Facebook;
    using Deadlock.FBMessengerPlatform.Client;

    static async Task SendBasicMessage()
    {
        FacebookClient client = new FacebookClient(_config.PageAccessToken);
        var result = await client.SendMessage(new Send()
        {
            recipient = new Recipient()
            {
                id = "{userid}"
            },
            message = new Message()
            {
                text = "hello, world!"
            }
        });
    }
```

### Send Image Message

```c#
    using Facebook;
    using Deadlock.FBMessengerPlatform.Client;
    
    static async Task SendImageMessage()
    {
        FacebookClient client = new FacebookClient(_config.PageAccessToken);
        var result = await client.SendMessage(new Send()
        {
            recipient = new Recipient()
            {
                id = "{userid}"
            },
            message = new Message()
            {
                attachment = new Deadlock.FBMessengerPlatform.Client.Attachment()
                {
                    type = "image",
                    payload = new ImagePayload()
                    {
                        url = "http://images.outbrain.com/imageserver/v2/s/Mdo3/n/1Nzpng/abc/1J8juy/1Nzpng-1lLg-420x340.jpg"
                    }
                }
            }
        });
    }
```

### Send Button Message

```c#
    using Facebook;
    using Deadlock.FBMessengerPlatform.Client;
    
    static async Task SendButtonMessage()
    {
        FacebookClient client = new FacebookClient(_config.PageAccessToken);
        var result = await client.SendMessage(new Send()
        {
            recipient = new Recipient()
            {
                id = "{userid}"
            },
            message = new Message()
            {
                attachment = new Attachment()
                {
                    type = "template",
                    payload = new ButtonPayloadTemplate()
                    {
                        text = "What do you want to do next?",
                        buttons = new List<Button>()
                    {
                        new Button()
                        {
                            type = "web_url",
                            url = "https://petersapparel.parseapp.com",
                            title = "Show Website"
                        },
                        new Button()
                        {
                            type = "postback",
                            payload = "USER_DEFINED_PAYLOAD",
                            title = "Start Chatting"
                        }
                    }
                    }
                }
            }
        });
    }
```

### Send Generic Message

```c#
    using Facebook;
    using Deadlock.FBMessengerPlatform.Client;
    
    static async Task SendGenericMessage()
    {
        FacebookClient client = new FacebookClient(_config.PageAccessToken);
        var result = await client.SendMessage(new Send()
        {
            recipient = new Recipient()
            {
                id = "{userid}"
            },
            message = new Message()
            {
                attachment = new Attachment()
                {
                    type = "template",
                    payload = new GenericPayloadTemplate()
                    {
                        elements = new List<GenericElement>()
                        {
                            new GenericElement()
                            {
                                title = "Classic White T-Shirt",
                                image_url = "http://petersapparel.parseapp.com/img/item100-thumb.png",
                                subtitle = "Soft white cotton t-shirt is back in style",
                                buttons = new List<Button>()
                                {
                                    new Button()
                                    {
                                        type = "web_url",
                                        url = "https://petersapparel.parseapp.com/view_item?item_id=100",
                                        title = "View Item"
                                    },
                                    new Button()
                                    {
                                        type = "web_url",
                                        url = "https://petersapparel.parseapp.com/buy_item?item_id=100",
                                        title = "Buy Item"
                                    },
                                    new Button()
                                    {
                                        type = "postback",
                                        payload = "USER_DEFINED_PAYLOAD_FOR_ITEM100",
                                        title = "Bookmark Item"
                                    }
                                }
                            },
                            new GenericElement()
                            {
                                title = "Classic Grey T-Shirt",
                                image_url = "http://petersapparel.parseapp.com/img/item101-thumb.png",
                                subtitle = "Soft gray cotton t-shirt is back in style",
                                buttons = new List<Button>()
                                {
                                    new Button()
                                    {
                                        type = "web_url",
                                        url = "https://petersapparel.parseapp.com/view_item?item_id=101",
                                        title = "View Item"
                                    },
                                    new Button()
                                    {
                                        type = "web_url",
                                        url = "https://petersapparel.parseapp.com/buy_item?item_id=101",
                                        title = "Buy Item"
                                    },
                                    new Button()
                                    {
                                        type = "postback",
                                        payload = "USER_DEFINED_PAYLOAD_FOR_ITEM101",
                                        title = "Bookmark Item"
                                    }
                                }
                            }
                        }
                    }
                }
            }
        });
    }
```

### Send Receipt Message

```c#
    using Facebook;
    using Deadlock.FBMessengerPlatform.Client;
    
    static async Task SendReceiptMessage()
    {
        FacebookClient client = new FacebookClient(_config.PageAccessToken);
        var result = await client.SendMessage(new Send()
        {
            recipient = new Recipient()
            {
                id = "{userid}"
            },
            message = new Message()
            {
                attachment = new Attachment()
                {
                    type = "template",
                    payload = new ReceiptPayloadTemplate()
                    {
                        recipient_name = "Stephane Crozatier",
                        order_number = "12345678902",
                        currency = "USD",
                        payment_method = "Visa 2345",
                        order_url = "http://petersapparel.parseapp.com/order?order_id=123456",
                        timestamp = "1428444852",
                        elements = new List<ReceiptElement>()
                        {
                            new ReceiptElement()
                            {
                                title = "Classic White T-Shirt",
                                subtitle = "100% Soft and Luxurious Cotton",
                                quantity = 2,
                                price = 50,
                                currency = "USD",
                                image_url = "http://petersapparel.parseapp.com/img/whiteshirt.png"
                            },
                            new ReceiptElement()
                            {
                                title = "Classic Gray T-Shirt",
                                subtitle = "100% Soft and Luxurious Cotton",
                                quantity = 1,
                                price = 25,
                                currency = "USD",
                                image_url = "http://petersapparel.parseapp.com/img/grayshirt.png"
                            }
                        },
                            address = new Address()
                            {
                                street_1 = "1 Hacker Way",
                                city = "Menlo Park",
                                postal_code = "94025",
                                state = "CA",
                                country = "US"
                            },
                            summary = new Summary()
                            {
                                subtotal = 75.00m,
                                shipping_cost = 4.95m,
                                total_tax = 6.19m,
                                total_cost = 56.14m
                            },
                            adjustments = new List<Adjustment>()
                        {
                            new Adjustment()
                            {
                                name = "New Customer Discount",
                                amount = 20
                            },
                            new Adjustment()
                            {
                                name = "$10 Off Coupon",
                                amount = 10
                            }
                        }
                    }
                }
            }
        });
    }
```