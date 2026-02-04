using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Extensions;

public static class Seeder
{
    static string user1 = "62f94fe7-0580-42df-969c-50d4165d63b9";
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        string USER_EMAIL = "Test@gmail.com";
        
        //create user
        var appUser = new User
        {
            Id = user1,
            Email = USER_EMAIL,
            EmailConfirmed = true,
            UserName = USER_EMAIL,
            NormalizedUserName = USER_EMAIL.ToUpper(),
            NormalizedEmail = USER_EMAIL.ToUpper(),
        };
        
        //set user password
        PasswordHasher<User> ph = new PasswordHasher<User>();
        appUser.PasswordHash = ph.HashPassword(appUser, "NeedReset%123");
        
        //seed user
        modelBuilder.Entity<User>().HasData(appUser);

        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, CategoryName = "Development Tools" },
            new Category { CategoryId = 2, CategoryName = "Productivity Software" },
            new Category { CategoryId = 3, CategoryName = "Design & Creative" },
            new Category { CategoryId = 4, CategoryName = "Database & Analytics" },
            new Category { CategoryId = 5, CategoryName = "Communication & Collaboration" },
            new Category { CategoryId = 6, CategoryName = "Project Management" },
            new Category { CategoryId = 7, CategoryName = "Version Control" },
            new Category { CategoryId = 8, CategoryName = "Video Conferencing" },
            new Category { CategoryId = 9, CategoryName = "Documentation" },
            new Category { CategoryId = 10, CategoryName = "Cloud Services" },
            new Category { CategoryId = 11, CategoryName = "Hardware" },
            new Category { CategoryId = 12, CategoryName = "Networking Equipment" },
            new Category { CategoryId = 13, CategoryName = "Computing Devices" },
            new Category { CategoryId = 14, CategoryName = "Storage Solutions" },
            new Category { CategoryId = 15, CategoryName = "Support Services" },
            new Category { CategoryId = 16, CategoryName = "Professional Services" },
            new Category { CategoryId = 17, CategoryName = "Training & Education" },
            new Category { CategoryId = 18, CategoryName = "Security Services" },
            new Category { CategoryId = 19, CategoryName = "Managed Services" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, ProductName = "Visual Studio Enterprise" },
            new Product { ProductId = 2, ProductName = "Microsoft 365 Business Premium" },
            new Product { ProductId = 3, ProductName = "Adobe Creative Cloud" },
            new Product { ProductId = 4, ProductName = "Salesforce CRM" },
            new Product { ProductId = 5, ProductName = "Slack Business+" },
            new Product { ProductId = 6, ProductName = "Jira Software" },
            new Product { ProductId = 7, ProductName = "GitHub Enterprise" },
            new Product { ProductId = 8, ProductName = "Zoom Workplace" },
            new Product { ProductId = 9, ProductName = "Confluence" },
            new Product { ProductId = 10, ProductName = "AutoCAD 2024" },
            new Product { ProductId = 11, ProductName = "HubSpot Marketing Hub" },
            new Product { ProductId = 12, ProductName = "Zendesk Support Suite" },
            new Product { ProductId = 13, ProductName = "MongoDB Atlas" },
            new Product { ProductId = 14, ProductName = "Atlassian Cloud" },
            new Product { ProductId = 15, ProductName = "Datadog Pro" },
            new Product { ProductId = 16, ProductName = "Figma Professional" },
            new Product { ProductId = 17, ProductName = "Notion Team Plan" },
            new Product { ProductId = 18, ProductName = "Asana Business" },
            new Product { ProductId = 19, ProductName = "Dell PowerEdge Server" },
            new Product { ProductId = 20, ProductName = "Cisco Catalyst Switch" },
            new Product { ProductId = 21, ProductName = "HP LaserJet Printer" },
            new Product { ProductId = 22, ProductName = "Lenovo ThinkPad Laptop" },
            new Product { ProductId = 23, ProductName = "Azure Virtual Machine" },
            new Product { ProductId = 24, ProductName = "AWS EC2 Instance" },
            new Product { ProductId = 25, ProductName = "Premium Support Package" },
            new Product { ProductId = 26, ProductName = "Cloud Migration Service" },
            new Product { ProductId = 27, ProductName = "Security Audit Service" },
            new Product { ProductId = 28, ProductName = "Training & Onboarding" },
            new Product { ProductId = 29, ProductName = "Managed IT Services" }
        );

        modelBuilder.Entity<Priority>().HasData(
            new Priority
            {
                PriorityId = 1,
                PriorityName = "Low",
                ExpectedDuration = 14
            },
            new Priority
            {
                PriorityId = 2,
                PriorityName = "Medium",
                ExpectedDuration = 7
            },
            new Priority
            {
                PriorityId = 3,
                PriorityName = "High",
                ExpectedDuration = 1
            }
        );

        Ticket(modelBuilder);
    }

    public static void Ticket(ModelBuilder modelBuilder)
    {
        var random = new Random(42);
        var statuses = new[] { "Open", "In Progress", "Resolved", "Closed", "Pending" };
        var startDate = new DateTime(2025, 1, 1);

        var tickets = new List<Ticket>();

        for (int i = 1; i <= 85; i++)
        {
            var createdDate = startDate.AddDays(random.Next(0, 365));
            var priorityId = random.Next(1, 4);
            var status = statuses[random.Next(statuses.Length)];
            var categoryId = random.Next(1, 20);
            var productId = random.Next(1, 30);

            DateTime? resolvedDate = null;
            DateTime? closedDate = null;
            DateTime? dueDate = null;

            if (status == "Resolved" || status == "Closed")
            {
                resolvedDate = createdDate.AddDays(random.Next(1, 30));
            }

            if (status == "Closed")
            {
                closedDate = resolvedDate?.AddDays(random.Next(1, 5));
            }

            if (status != "Closed")
            {
                dueDate = createdDate.AddDays(priorityId == 3 ? 1 : (priorityId == 2 ? 7 : 14));
            }

            tickets.Add(new Ticket
            {
                TicketId = i,
                Title = $"Issue with {GetProductName(productId)}",
                Summary = GetSummary(categoryId, productId, i),
                Description = GetDescription(categoryId, productId, i),
                CreatedDate = createdDate,
                ClosedDate = closedDate,
                ResolvedDate = resolvedDate,
                DueDate = dueDate,
                AssigneeId = user1,
                CreatedBy = user1,
                CategoryId = categoryId,
                ProductId = productId,
                PriorityId = priorityId,
                Status = status
            });
        }

        modelBuilder.Entity<Ticket>().HasData(tickets);
    }

    private static string GetProductName(int productId)
    {
        var products = new[] {
            "Visual Studio Enterprise", "Microsoft 365 Business Premium", "Adobe Creative Cloud",
            "Salesforce CRM", "Slack Business+", "Jira Software", "GitHub Enterprise",
            "Zoom Workplace", "Confluence", "AutoCAD 2024", "HubSpot Marketing Hub",
            "Zendesk Support Suite", "MongoDB Atlas", "Atlassian Cloud", "Datadog Pro",
            "Figma Professional", "Notion Team Plan", "Asana Business", "Dell PowerEdge Server",
            "Cisco Catalyst Switch", "HP LaserJet Printer", "Lenovo ThinkPad Laptop",
            "Azure Virtual Machine", "AWS EC2 Instance", "Premium Support Package",
            "Cloud Migration Service", "Security Audit Service", "Training & Onboarding",
            "Managed IT Services"
        };
        return products[productId - 1];
    }

    private static string GetSummary(int categoryId, int productId, int ticketId)
    {
        var summaries = new[]
        {
            "Unable to access application after recent update",
            "Performance degradation during peak hours",
            "Integration with third-party service failing",
            "Authentication tokens expiring prematurely",
            "Data synchronization issues between systems",
            "UI elements not rendering correctly on mobile",
            "Email notifications not being delivered",
            "API rate limiting causing service disruption",
            "Database connection pool exhausted",
            "File upload functionality not working",
            "Search feature returning incorrect results",
            "User permissions not being applied correctly",
            "Dashboard widgets displaying stale data",
            "Export functionality generating corrupted files",
            "Scheduled tasks not executing on time",
            "Memory leak causing application crashes",
            "SSL certificate renewal required",
            "Backup process failing intermittently",
            "Load balancer health check failures",
            "Cache invalidation not working properly",
            "Session timeout occurring too frequently",
            "Webhook endpoints returning 500 errors",
            "PDF generation service is down",
            "Analytics tracking not capturing events",
            "Two-factor authentication bypass detected",
            "Logging service disk space full",
            "CDN purge requests timing out",
            "VPN connection drops randomly",
            "Printer queue stuck with pending jobs",
            "Network latency spikes during business hours",
            "Server hardware diagnostics showing errors",
            "Software license needs renewal",
            "User onboarding process not completing",
            "Report generation taking too long",
            "Mobile app crashing on startup",
            "API documentation outdated",
            "Feature request: Dark mode support",
            "Security vulnerability identified",
            "Compliance audit findings need addressing",
            "Migration to new infrastructure required"
        };
        return summaries[ticketId % summaries.Length];
    }

    private static string GetDescription(int categoryId, int productId, int ticketId)
    {
        var descriptions = new[]
        {
            "Users are reporting that they cannot log in after the latest deployment. The login page loads but credentials are not being accepted. This is affecting approximately 30% of users.",
            "The application response time has increased significantly during peak hours (9 AM - 12 PM). Average response time has gone from 200ms to 3 seconds. Database queries appear to be the bottleneck.",
            "After configuring the integration, the service returns a 403 Forbidden error. API credentials have been verified and are correct. The issue started after a network policy change.",
            "Users are being logged out every 10 minutes despite the session timeout being configured for 60 minutes. This is causing workflow interruptions and data loss.",
            "Data changes made in the primary system are not reflecting in the secondary system. The sync job logs show successful completion but data remains inconsistent.",
            "Several UI components including buttons, dropdowns, and modals are misaligned on mobile devices. The responsive design breakpoints may need adjustment.",
            "Automated email notifications for password resets and account confirmations are not reaching users. SMTP logs show messages are being sent but users report not receiving them.",
            "The API is hitting rate limits during normal operation, causing service disruptions. Current limit is 1000 requests per hour but we're seeing legitimate traffic exceeding this.",
            "Application is throwing database connection errors during peak load. Connection pool settings may need to be increased or connections are not being properly released.",
            "Users attempting to upload files larger than 5MB are seeing timeout errors. Smaller files upload successfully. This may be related to reverse proxy timeout settings.",
            "Search functionality is returning results that don't match the query criteria. Appears to be an issue with the search index or query parsing logic.",
            "Role-based access controls are not being enforced correctly. Some users are seeing data they should not have access to based on their assigned roles.",
            "Dashboard widgets are showing data from yesterday even after refreshing the page. The real-time update mechanism appears to be broken.",
            "CSV exports contain garbled text and formatting issues. Excel files open with encoding errors. This started after upgrading the export library.",
            "Scheduled maintenance tasks configured to run daily at 2 AM are executing at random times or not at all. Task scheduler logs show inconsistent behavior.",
            "Application memory usage grows continuously until the process crashes. This suggests a memory leak possibly in the caching layer or event handlers.",
            "SSL certificate expires in 7 days. Need to generate CSR, obtain new certificate, and deploy without service interruption. Current cert was issued 12 months ago.",
            "Nightly backup jobs are failing 2-3 times per week with timeout errors. Backup size has grown to 500GB which may be exceeding the configured timeout window.",
            "Load balancer health checks are failing intermittently causing servers to be removed from rotation unnecessarily. This is impacting service availability.",
            "Cache invalidation events are not propagating across all application servers. This results in some users seeing stale data while others see updated data.",
            "Users are being logged out after 5 minutes of inactivity despite session timeout being set to 30 minutes. This is affecting user experience and productivity.",
            "Webhook POST requests are returning 500 Internal Server Error. The webhook endpoint logs show database query timeout exceptions during payload processing.",
            "PDF generation service has been down for 3 hours. Users cannot generate reports, invoices, or documents. Service health check endpoint is not responding.",
            "Analytics events for user actions like button clicks and page views are not being recorded. This started after the recent frontend framework update.",
            "Security audit discovered a vulnerability allowing users to bypass 2FA by manipulating session cookies. This needs immediate patching.",
            "Logging server disk utilization is at 98%. Old logs need to be archived or purged. Logging verbosity may need to be reduced to slow growth rate.",
            "CDN cache purge API requests are timing out after 30 seconds. This prevents immediate propagation of updated content to edge locations.",
            "VPN connections are dropping every 15-20 minutes requiring users to reconnect. This is disrupting remote work and causing frustration.",
            "Print jobs are stuck in queue and not processing. Printer service needs to be restarted but this requires coordination with affected users.",
            "Network latency between application server and database server spikes to 500ms+ during business hours. This correlates with increased user activity.",
            "Server hardware diagnostics indicate potential disk failure. SMART status shows reallocated sector count increasing. Proactive disk replacement recommended.",
            "Software license expires in 30 days. Need to process renewal, obtain new license key, and apply without requiring application downtime.",
            "New user onboarding workflow hangs at the email verification step. Users click verification link but account remains in pending state.",
            "Monthly management reports that normally take 2 minutes are now taking 30+ minutes to generate. Database query optimization needed.",
            "Mobile application crashes immediately on launch for users running Android 14. Stack trace indicates null pointer exception in initialization code.",
            "API documentation portal shows endpoints and parameters that were deprecated 6 months ago. Documentation needs to be updated to reflect current API.",
            "Multiple users have requested dark mode support for the application. This would improve usability in low-light environments.",
            "Security scan identified SQL injection vulnerability in search functionality. Input sanitization needs to be implemented before this can be exploited.",
            "Compliance audit found that user data retention exceeds policy requirements. Need to implement automated data purging for accounts inactive over 2 years.",
            "Current infrastructure is end-of-life and no longer receiving security patches. Migration to new infrastructure required within 90 days."
        };
        return descriptions[ticketId % descriptions.Length];
    }
    
}