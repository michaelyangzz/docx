# Limitations
## App Service on Linux does have some limitations:

- App Service on Linux isn't supported on Shared pricing tier.
- The Azure portal shows only features that currently work for Linux apps. As features are enabled, they're activated on the portal.
- When deployed to built-in images, your code and content are allocated a storage volume for web content, backed by Azure Storage. The disk latency of this volume is higher and more variable than the latency of the container filesystem. Apps that require heavy read-only access to content files might benefit from the custom container option, which places files in the container filesystem instead of on the content volume.

# Sidecar containers

In Azure App Service, you can add up to nine sidecar containers for each sidecar-enabled custom container app. Sidecar containers let you deploy extra services and features to your container application without making them tightly coupled to your main application container. For example, you can add monitoring, logging, configuration, and networking services as sidecar containers.

You can add a sidecar container through the Deployment Center in the app's management page.

# App Setting

In a default Linux app service or a custom Linux container, any nested JSON key structure in the app setting name like ApplicationInsights:InstrumentationKey needs to be configured in App Service as ApplicationInsights__InstrumentationKey for the key name. In other words, replace any : with __ (double underscore). Any periods in the app setting name are replaced with a _ (single underscore).

# Connection String in App Setting

- For other language stacks, it's better to use app settings instead of connection strings

- There's one case where you may want to use connection strings instead of app settings for non-.NET languages: certain Azure database types are backed up along with the app only if you configure a connection string for the database in your App Service app.
- .NET apps targeting PostgreSQL should set the connection string to Custom as work around for a known issue in .NET EnvironmentVariablesConfigurationProvider.

# General Settings
- Always On: Keeps the app loaded even when there's no traffic. When Always On isn't turned on (default), the app is unloaded after 20 minutes without any incoming requests. The unloaded app can cause high latency for new requests because of its warm-up time. When Always On is turned on, the front-end load balancer sends a GET request to the application root every five minutes. The continuous ping prevents the app from being unloaded.

- Always On is required for continuous WebJobs or for WebJobs that are triggered using a CRON expression.

# Certificate 
- Before you create a free managed certificate, make sure you meet the prerequisites for your app. Free certificates are issued by DigiCert. For some domains, you must explicitly allow DigiCert as a certificate issuer by creating a CAA domain record with the value: 0 issue digicert.com. Azure fully manages the certificates on your behalf, so any aspect of the managed certificate, including the root issuer, can change at any time. These changes are outside your control. Make sure to avoid hard dependencies and "pinning" practice certificates to the managed certificate or any part of the certificate hierarchy.

