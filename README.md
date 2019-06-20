# Delegates & Events

Quick demo of how to use delegates and events in C#.

## Setting up the event

In our class called UserProcessor.cs we need to set up three things:

1. The delegate
` public delegate void UserProcesserEventHandler(object source, EventArgs args);`

2. The Event:
`public event UserProcesserEventHandler UserProcessed;`

3. The Event Handler notice the virtual keyword
```
 protected virtual void OnUserProcessed()
        {
            if (UserProcessed != null)
            {
                UserProcessed(this, EventArgs.Empty);
            }
        }
```

This allows us to fire off notifications by simply calling `OnUserProcessed()`

## Setting up the subscribers

When we want to create a subscriber to the above events we need to abide by the contract defined in the delegate we created on our UserProcessor.cs class
For instance our `EmailNotificationService` class has a method called OnUserProcessed with a signature matching the delegate:
```
public void OnUserProcessed(object sender, EventArgs args)
        {
            SendEmail();
        }
```

## Wiring it all up

All that's left to do now is have our services subscribed to the events. To see this in action we jump over to our `Program.cs` file where we have the following code:

```
  var processor = new UserProcessor();
  var emailService = new EmailNotificationService();
  var textService = new TextMessageNotificationService();
  processor.UserProcessed += emailService.OnUserProcessed;
  processor.UserProcessed += textService.OnUserProcessed;
```

As you can see we're creating a new instance of everything we need and creating the subscriptions to the events.

Now when we run the application, not only does the message from the `UserProcessor.cs` show up in the console, but also any message sent by subscribers to the `UserProcessed` get sent to the console as well.


