using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seeder_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountConfirmed", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", 0, false, null, "0d5cd626-d93d-412b-8773-6884701b9e29", "Test@gmail.com", true, false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAIAAYagAAAAEL/DPawTx5kFHsgiqgxkIfzvP9g/qD4I7XjMy0+zAwuExsv4I87KxAUyYs3O43vB3A==", null, false, "ac0a41fc-46f4-4673-80b2-bab4a5dfc4ee", false, "Test@gmail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Development Tools" },
                    { 2, "Productivity Software" },
                    { 3, "Design & Creative" },
                    { 4, "Database & Analytics" },
                    { 5, "Communication & Collaboration" },
                    { 6, "Project Management" },
                    { 7, "Version Control" },
                    { 8, "Video Conferencing" },
                    { 9, "Documentation" },
                    { 10, "Cloud Services" },
                    { 11, "Hardware" },
                    { 12, "Networking Equipment" },
                    { 13, "Computing Devices" },
                    { 14, "Storage Solutions" },
                    { 15, "Support Services" },
                    { 16, "Professional Services" },
                    { 17, "Training & Education" },
                    { 18, "Security Services" },
                    { 19, "Managed Services" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "ExpectedDuration", "PriorityName" },
                values: new object[,]
                {
                    { 1, 14, "Low" },
                    { 2, 7, "Medium" },
                    { 3, 1, "High" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName" },
                values: new object[,]
                {
                    { 1, "Visual Studio Enterprise" },
                    { 2, "Microsoft 365 Business Premium" },
                    { 3, "Adobe Creative Cloud" },
                    { 4, "Salesforce CRM" },
                    { 5, "Slack Business+" },
                    { 6, "Jira Software" },
                    { 7, "GitHub Enterprise" },
                    { 8, "Zoom Workplace" },
                    { 9, "Confluence" },
                    { 10, "AutoCAD 2024" },
                    { 11, "HubSpot Marketing Hub" },
                    { 12, "Zendesk Support Suite" },
                    { 13, "MongoDB Atlas" },
                    { 14, "Atlassian Cloud" },
                    { 15, "Datadog Pro" },
                    { 16, "Figma Professional" },
                    { 17, "Notion Team Plan" },
                    { 18, "Asana Business" },
                    { 19, "Dell PowerEdge Server" },
                    { 20, "Cisco Catalyst Switch" },
                    { 21, "HP LaserJet Printer" },
                    { 22, "Lenovo ThinkPad Laptop" },
                    { 23, "Azure Virtual Machine" },
                    { 24, "AWS EC2 Instance" },
                    { 25, "Premium Support Package" },
                    { 26, "Cloud Migration Service" },
                    { 27, "Security Audit Service" },
                    { 28, "Training & Onboarding" },
                    { 29, "Managed IT Services" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssigneeId", "CategoryId", "ClosedDate", "CreatedBy", "CreatedDate", "Description", "DueDate", "PriorityId", "ProductId", "ResolvedDate", "Status", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "62f94fe7-0580-42df-969c-50d4165d63b9", 10, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The application response time has increased significantly during peak hours (9 AM - 12 PM). Average response time has gone from 200ms to 3 seconds. Database queries appear to be the bottleneck.", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, null, "Open", "Performance degradation during peak hours", "Issue with Slack Business+" },
                    { 2, "62f94fe7-0580-42df-969c-50d4165d63b9", 4, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "After configuring the integration, the service returns a 403 Forbidden error. API credentials have been verified and are correct. The issue started after a network policy change.", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 23, new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Integration with third-party service failing", "Issue with Azure Virtual Machine" },
                    { 3, "62f94fe7-0580-42df-969c-50d4165d63b9", 8, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users are being logged out every 10 minutes despite the session timeout being configured for 60 minutes. This is causing workflow interruptions and data loss.", new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8, null, "In Progress", "Authentication tokens expiring prematurely", "Issue with Zoom Workplace" },
                    { 4, "62f94fe7-0580-42df-969c-50d4165d63b9", 11, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data changes made in the primary system are not reflecting in the secondary system. The sync job logs show successful completion but data remains inconsistent.", new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12, null, "Pending", "Data synchronization issues between systems", "Issue with Zendesk Support Suite" },
                    { 5, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Several UI components including buttons, dropdowns, and modals are misaligned on mobile devices. The responsive design breakpoints may need adjustment.", null, 1, 16, new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "UI elements not rendering correctly on mobile", "Issue with Figma Professional" },
                    { 6, "62f94fe7-0580-42df-969c-50d4165d63b9", 10, new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automated email notifications for password resets and account confirmations are not reaching users. SMTP logs show messages are being sent but users report not receiving them.", null, 3, 6, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Email notifications not being delivered", "Issue with Jira Software" },
                    { 7, "62f94fe7-0580-42df-969c-50d4165d63b9", 11, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The API is hitting rate limits during normal operation, causing service disruptions. Current limit is 1000 requests per hour but we're seeing legitimate traffic exceeding this.", new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 24, null, "Open", "API rate limiting causing service disruption", "Issue with AWS EC2 Instance" },
                    { 8, "62f94fe7-0580-42df-969c-50d4165d63b9", 1, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Application is throwing database connection errors during peak load. Connection pool settings may need to be increased or connections are not being properly released.", new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null, "Open", "Database connection pool exhausted", "Issue with Microsoft 365 Business Premium" },
                    { 9, "62f94fe7-0580-42df-969c-50d4165d63b9", 5, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users attempting to upload files larger than 5MB are seeing timeout errors. Smaller files upload successfully. This may be related to reverse proxy timeout settings.", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 23, null, "Open", "File upload functionality not working", "Issue with Azure Virtual Machine" },
                    { 10, "62f94fe7-0580-42df-969c-50d4165d63b9", 1, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Search functionality is returning results that don't match the query criteria. Appears to be an issue with the search index or query parsing logic.", new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 18, null, "Open", "Search feature returning incorrect results", "Issue with Asana Business" },
                    { 11, "62f94fe7-0580-42df-969c-50d4165d63b9", 14, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Role-based access controls are not being enforced correctly. Some users are seeing data they should not have access to based on their assigned roles.", new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 19, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "User permissions not being applied correctly", "Issue with Dell PowerEdge Server" },
                    { 12, "62f94fe7-0580-42df-969c-50d4165d63b9", 2, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dashboard widgets are showing data from yesterday even after refreshing the page. The real-time update mechanism appears to be broken.", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 21, null, "In Progress", "Dashboard widgets displaying stale data", "Issue with HP LaserJet Printer" },
                    { 13, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "CSV exports contain garbled text and formatting issues. Excel files open with encoding errors. This started after upgrading the export library.", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 13, null, "Open", "Export functionality generating corrupted files", "Issue with MongoDB Atlas" },
                    { 14, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled maintenance tasks configured to run daily at 2 AM are executing at random times or not at all. Task scheduler logs show inconsistent behavior.", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null, "Open", "Scheduled tasks not executing on time", "Issue with Visual Studio Enterprise" },
                    { 15, "62f94fe7-0580-42df-969c-50d4165d63b9", 1, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Application memory usage grows continuously until the process crashes. This suggests a memory leak possibly in the caching layer or event handlers.", null, 1, 27, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Memory leak causing application crashes", "Issue with Security Audit Service" },
                    { 16, "62f94fe7-0580-42df-969c-50d4165d63b9", 8, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SSL certificate expires in 7 days. Need to generate CSR, obtain new certificate, and deploy without service interruption. Current cert was issued 12 months ago.", new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, null, "Open", "SSL certificate renewal required", "Issue with Slack Business+" },
                    { 17, "62f94fe7-0580-42df-969c-50d4165d63b9", 8, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nightly backup jobs are failing 2-3 times per week with timeout errors. Backup size has grown to 500GB which may be exceeding the configured timeout window.", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9, new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Backup process failing intermittently", "Issue with Confluence" },
                    { 18, "62f94fe7-0580-42df-969c-50d4165d63b9", 17, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Load balancer health checks are failing intermittently causing servers to be removed from rotation unnecessarily. This is impacting service availability.", new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 28, null, "Open", "Load balancer health check failures", "Issue with Training & Onboarding" },
                    { 19, "62f94fe7-0580-42df-969c-50d4165d63b9", 2, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cache invalidation events are not propagating across all application servers. This results in some users seeing stale data while others see updated data.", new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 14, null, "Open", "Cache invalidation not working properly", "Issue with Atlassian Cloud" },
                    { 20, "62f94fe7-0580-42df-969c-50d4165d63b9", 3, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users are being logged out after 5 minutes of inactivity despite session timeout being set to 30 minutes. This is affecting user experience and productivity.", new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, null, "Open", "Session timeout occurring too frequently", "Issue with GitHub Enterprise" },
                    { 21, "62f94fe7-0580-42df-969c-50d4165d63b9", 15, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webhook POST requests are returning 500 Internal Server Error. The webhook endpoint logs show database query timeout exceptions during payload processing.", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20, null, "Pending", "Webhook endpoints returning 500 errors", "Issue with Cisco Catalyst Switch" },
                    { 22, "62f94fe7-0580-42df-969c-50d4165d63b9", 19, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "PDF generation service has been down for 3 hours. Users cannot generate reports, invoices, or documents. Service health check endpoint is not responding.", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 19, new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "PDF generation service is down", "Issue with Dell PowerEdge Server" },
                    { 23, "62f94fe7-0580-42df-969c-50d4165d63b9", 5, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analytics events for user actions like button clicks and page views are not being recorded. This started after the recent frontend framework update.", new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8, null, "Open", "Analytics tracking not capturing events", "Issue with Zoom Workplace" },
                    { 24, "62f94fe7-0580-42df-969c-50d4165d63b9", 9, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Security audit discovered a vulnerability allowing users to bypass 2FA by manipulating session cookies. This needs immediate patching.", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Two-factor authentication bypass detected", "Issue with Adobe Creative Cloud" },
                    { 25, "62f94fe7-0580-42df-969c-50d4165d63b9", 7, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logging server disk utilization is at 98%. Old logs need to be archived or purged. Logging verbosity may need to be reduced to slow growth rate.", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 22, null, "In Progress", "Logging service disk space full", "Issue with Lenovo ThinkPad Laptop" },
                    { 26, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "CDN cache purge API requests are timing out after 30 seconds. This prevents immediate propagation of updated content to edge locations.", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 26, null, "Open", "CDN purge requests timing out", "Issue with Cloud Migration Service" },
                    { 27, "62f94fe7-0580-42df-969c-50d4165d63b9", 6, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VPN connections are dropping every 15-20 minutes requiring users to reconnect. This is disrupting remote work and causing frustration.", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 16, null, "Pending", "VPN connection drops randomly", "Issue with Figma Professional" },
                    { 28, "62f94fe7-0580-42df-969c-50d4165d63b9", 6, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Print jobs are stuck in queue and not processing. Printer service needs to be restarted but this requires coordination with affected users.", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, null, "Open", "Printer queue stuck with pending jobs", "Issue with Jira Software" },
                    { 29, "62f94fe7-0580-42df-969c-50d4165d63b9", 19, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Network latency between application server and database server spikes to 500ms+ during business hours. This correlates with increased user activity.", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 23, null, "Pending", "Network latency spikes during business hours", "Issue with Azure Virtual Machine" },
                    { 30, "62f94fe7-0580-42df-969c-50d4165d63b9", 6, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Server hardware diagnostics indicate potential disk failure. SMART status shows reallocated sector count increasing. Proactive disk replacement recommended.", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 17, null, "Open", "Server hardware diagnostics showing errors", "Issue with Notion Team Plan" },
                    { 31, "62f94fe7-0580-42df-969c-50d4165d63b9", 12, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software license expires in 30 days. Need to process renewal, obtain new license key, and apply without requiring application downtime.", new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 12, null, "Open", "Software license needs renewal", "Issue with Zendesk Support Suite" },
                    { 32, "62f94fe7-0580-42df-969c-50d4165d63b9", 19, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "New user onboarding workflow hangs at the email verification step. Users click verification link but account remains in pending state.", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 14, null, "In Progress", "User onboarding process not completing", "Issue with Atlassian Cloud" },
                    { 33, "62f94fe7-0580-42df-969c-50d4165d63b9", 3, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monthly management reports that normally take 2 minutes are now taking 30+ minutes to generate. Database query optimization needed.", new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null, "Pending", "Report generation taking too long", "Issue with Salesforce CRM" },
                    { 34, "62f94fe7-0580-42df-969c-50d4165d63b9", 14, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobile application crashes immediately on launch for users running Android 14. Stack trace indicates null pointer exception in initialization code.", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12, null, "Pending", "Mobile app crashing on startup", "Issue with Zendesk Support Suite" },
                    { 35, "62f94fe7-0580-42df-969c-50d4165d63b9", 18, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "API documentation portal shows endpoints and parameters that were deprecated 6 months ago. Documentation needs to be updated to reflect current API.", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 28, null, "Open", "API documentation outdated", "Issue with Training & Onboarding" },
                    { 36, "62f94fe7-0580-42df-969c-50d4165d63b9", 11, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multiple users have requested dark mode support for the application. This would improve usability in low-light environments.", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18, null, "In Progress", "Feature request: Dark mode support", "Issue with Asana Business" },
                    { 37, "62f94fe7-0580-42df-969c-50d4165d63b9", 6, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Security scan identified SQL injection vulnerability in search functionality. Input sanitization needs to be implemented before this can be exploited.", null, 3, 10, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Security vulnerability identified", "Issue with AutoCAD 2024" },
                    { 38, "62f94fe7-0580-42df-969c-50d4165d63b9", 4, new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance audit found that user data retention exceeds policy requirements. Need to implement automated data purging for accounts inactive over 2 years.", null, 3, 9, new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Compliance audit findings need addressing", "Issue with Confluence" },
                    { 39, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Current infrastructure is end-of-life and no longer receiving security patches. Migration to new infrastructure required within 90 days.", new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 26, new DateTime(2025, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Migration to new infrastructure required", "Issue with Cloud Migration Service" },
                    { 40, "62f94fe7-0580-42df-969c-50d4165d63b9", 17, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users are reporting that they cannot log in after the latest deployment. The login page loads but credentials are not being accepted. This is affecting approximately 30% of users.", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 29, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Unable to access application after recent update", "Issue with Managed IT Services" },
                    { 41, "62f94fe7-0580-42df-969c-50d4165d63b9", 10, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The application response time has increased significantly during peak hours (9 AM - 12 PM). Average response time has gone from 200ms to 3 seconds. Database queries appear to be the bottleneck.", null, 1, 21, new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Performance degradation during peak hours", "Issue with HP LaserJet Printer" },
                    { 42, "62f94fe7-0580-42df-969c-50d4165d63b9", 4, new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "After configuring the integration, the service returns a 403 Forbidden error. API credentials have been verified and are correct. The issue started after a network policy change.", null, 2, 16, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Integration with third-party service failing", "Issue with Figma Professional" },
                    { 43, "62f94fe7-0580-42df-969c-50d4165d63b9", 2, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users are being logged out every 10 minutes despite the session timeout being configured for 60 minutes. This is causing workflow interruptions and data loss.", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, null, "Open", "Authentication tokens expiring prematurely", "Issue with GitHub Enterprise" },
                    { 44, "62f94fe7-0580-42df-969c-50d4165d63b9", 6, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data changes made in the primary system are not reflecting in the secondary system. The sync job logs show successful completion but data remains inconsistent.", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 26, null, "In Progress", "Data synchronization issues between systems", "Issue with Cloud Migration Service" },
                    { 45, "62f94fe7-0580-42df-969c-50d4165d63b9", 15, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Several UI components including buttons, dropdowns, and modals are misaligned on mobile devices. The responsive design breakpoints may need adjustment.", new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "UI elements not rendering correctly on mobile", "Issue with Cisco Catalyst Switch" },
                    { 46, "62f94fe7-0580-42df-969c-50d4165d63b9", 4, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automated email notifications for password resets and account confirmations are not reaching users. SMTP logs show messages are being sent but users report not receiving them.", new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 28, null, "In Progress", "Email notifications not being delivered", "Issue with Training & Onboarding" },
                    { 47, "62f94fe7-0580-42df-969c-50d4165d63b9", 19, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The API is hitting rate limits during normal operation, causing service disruptions. Current limit is 1000 requests per hour but we're seeing legitimate traffic exceeding this.", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null, "In Progress", "API rate limiting causing service disruption", "Issue with Adobe Creative Cloud" },
                    { 48, "62f94fe7-0580-42df-969c-50d4165d63b9", 18, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Application is throwing database connection errors during peak load. Connection pool settings may need to be increased or connections are not being properly released.", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 26, null, "In Progress", "Database connection pool exhausted", "Issue with Cloud Migration Service" },
                    { 49, "62f94fe7-0580-42df-969c-50d4165d63b9", 12, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users attempting to upload files larger than 5MB are seeing timeout errors. Smaller files upload successfully. This may be related to reverse proxy timeout settings.", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, "In Progress", "File upload functionality not working", "Issue with Visual Studio Enterprise" },
                    { 50, "62f94fe7-0580-42df-969c-50d4165d63b9", 13, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Search functionality is returning results that don't match the query criteria. Appears to be an issue with the search index or query parsing logic.", null, 2, 29, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Search feature returning incorrect results", "Issue with Managed IT Services" },
                    { 51, "62f94fe7-0580-42df-969c-50d4165d63b9", 13, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Role-based access controls are not being enforced correctly. Some users are seeing data they should not have access to based on their assigned roles.", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null, "In Progress", "User permissions not being applied correctly", "Issue with Microsoft 365 Business Premium" },
                    { 52, "62f94fe7-0580-42df-969c-50d4165d63b9", 7, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dashboard widgets are showing data from yesterday even after refreshing the page. The real-time update mechanism appears to be broken.", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7, null, "In Progress", "Dashboard widgets displaying stale data", "Issue with GitHub Enterprise" },
                    { 53, "62f94fe7-0580-42df-969c-50d4165d63b9", 7, new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "CSV exports contain garbled text and formatting issues. Excel files open with encoding errors. This started after upgrading the export library.", null, 2, 20, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Export functionality generating corrupted files", "Issue with Cisco Catalyst Switch" },
                    { 54, "62f94fe7-0580-42df-969c-50d4165d63b9", 7, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled maintenance tasks configured to run daily at 2 AM are executing at random times or not at all. Task scheduler logs show inconsistent behavior.", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, "Pending", "Scheduled tasks not executing on time", "Issue with Visual Studio Enterprise" },
                    { 55, "62f94fe7-0580-42df-969c-50d4165d63b9", 4, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Application memory usage grows continuously until the process crashes. This suggests a memory leak possibly in the caching layer or event handlers.", new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 19, null, "Open", "Memory leak causing application crashes", "Issue with Dell PowerEdge Server" },
                    { 56, "62f94fe7-0580-42df-969c-50d4165d63b9", 13, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SSL certificate expires in 7 days. Need to generate CSR, obtain new certificate, and deploy without service interruption. Current cert was issued 12 months ago.", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, null, "Open", "SSL certificate renewal required", "Issue with Jira Software" },
                    { 57, "62f94fe7-0580-42df-969c-50d4165d63b9", 7, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nightly backup jobs are failing 2-3 times per week with timeout errors. Backup size has grown to 500GB which may be exceeding the configured timeout window.", new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 18, null, "Pending", "Backup process failing intermittently", "Issue with Asana Business" },
                    { 58, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Load balancer health checks are failing intermittently causing servers to be removed from rotation unnecessarily. This is impacting service availability.", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 17, null, "Open", "Load balancer health check failures", "Issue with Notion Team Plan" },
                    { 59, "62f94fe7-0580-42df-969c-50d4165d63b9", 13, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cache invalidation events are not propagating across all application servers. This results in some users seeing stale data while others see updated data.", new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 29, new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Cache invalidation not working properly", "Issue with Managed IT Services" },
                    { 60, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users are being logged out after 5 minutes of inactivity despite session timeout being set to 30 minutes. This is affecting user experience and productivity.", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 21, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Session timeout occurring too frequently", "Issue with HP LaserJet Printer" },
                    { 61, "62f94fe7-0580-42df-969c-50d4165d63b9", 19, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webhook POST requests are returning 500 Internal Server Error. The webhook endpoint logs show database query timeout exceptions during payload processing.", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15, new DateTime(2025, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Webhook endpoints returning 500 errors", "Issue with Datadog Pro" },
                    { 62, "62f94fe7-0580-42df-969c-50d4165d63b9", 4, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "PDF generation service has been down for 3 hours. Users cannot generate reports, invoices, or documents. Service health check endpoint is not responding.", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 17, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "PDF generation service is down", "Issue with Notion Team Plan" },
                    { 63, "62f94fe7-0580-42df-969c-50d4165d63b9", 6, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analytics events for user actions like button clicks and page views are not being recorded. This started after the recent frontend framework update.", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Analytics tracking not capturing events", "Issue with Datadog Pro" },
                    { 64, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Security audit discovered a vulnerability allowing users to bypass 2FA by manipulating session cookies. This needs immediate patching.", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 14, null, "Open", "Two-factor authentication bypass detected", "Issue with Atlassian Cloud" },
                    { 65, "62f94fe7-0580-42df-969c-50d4165d63b9", 4, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logging server disk utilization is at 98%. Old logs need to be archived or purged. Logging verbosity may need to be reduced to slow growth rate.", new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 28, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Logging service disk space full", "Issue with Training & Onboarding" },
                    { 66, "62f94fe7-0580-42df-969c-50d4165d63b9", 10, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CDN cache purge API requests are timing out after 30 seconds. This prevents immediate propagation of updated content to edge locations.", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10, null, "Pending", "CDN purge requests timing out", "Issue with AutoCAD 2024" },
                    { 67, "62f94fe7-0580-42df-969c-50d4165d63b9", 12, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VPN connections are dropping every 15-20 minutes requiring users to reconnect. This is disrupting remote work and causing frustration.", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 27, null, "Pending", "VPN connection drops randomly", "Issue with Security Audit Service" },
                    { 68, "62f94fe7-0580-42df-969c-50d4165d63b9", 3, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Print jobs are stuck in queue and not processing. Printer service needs to be restarted but this requires coordination with affected users.", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 11, null, "In Progress", "Printer queue stuck with pending jobs", "Issue with HubSpot Marketing Hub" },
                    { 69, "62f94fe7-0580-42df-969c-50d4165d63b9", 1, new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Network latency between application server and database server spikes to 500ms+ during business hours. This correlates with increased user activity.", null, 1, 7, new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Network latency spikes during business hours", "Issue with GitHub Enterprise" },
                    { 70, "62f94fe7-0580-42df-969c-50d4165d63b9", 3, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Server hardware diagnostics indicate potential disk failure. SMART status shows reallocated sector count increasing. Proactive disk replacement recommended.", new DateTime(2025, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 23, new DateTime(2025, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Server hardware diagnostics showing errors", "Issue with Azure Virtual Machine" },
                    { 71, "62f94fe7-0580-42df-969c-50d4165d63b9", 13, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software license expires in 30 days. Need to process renewal, obtain new license key, and apply without requiring application downtime.", new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null, "Open", "Software license needs renewal", "Issue with Adobe Creative Cloud" },
                    { 72, "62f94fe7-0580-42df-969c-50d4165d63b9", 14, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "New user onboarding workflow hangs at the email verification step. Users click verification link but account remains in pending state.", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 27, new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "User onboarding process not completing", "Issue with Security Audit Service" },
                    { 73, "62f94fe7-0580-42df-969c-50d4165d63b9", 17, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monthly management reports that normally take 2 minutes are now taking 30+ minutes to generate. Database query optimization needed.", new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 24, new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Report generation taking too long", "Issue with AWS EC2 Instance" },
                    { 74, "62f94fe7-0580-42df-969c-50d4165d63b9", 2, new DateTime(2026, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobile application crashes immediately on launch for users running Android 14. Stack trace indicates null pointer exception in initialization code.", null, 3, 24, new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Mobile app crashing on startup", "Issue with AWS EC2 Instance" },
                    { 75, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "API documentation portal shows endpoints and parameters that were deprecated 6 months ago. Documentation needs to be updated to reflect current API.", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 24, null, "Pending", "API documentation outdated", "Issue with AWS EC2 Instance" },
                    { 76, "62f94fe7-0580-42df-969c-50d4165d63b9", 6, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multiple users have requested dark mode support for the application. This would improve usability in low-light environments.", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 24, null, "Open", "Feature request: Dark mode support", "Issue with AWS EC2 Instance" },
                    { 77, "62f94fe7-0580-42df-969c-50d4165d63b9", 18, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Security scan identified SQL injection vulnerability in search functionality. Input sanitization needs to be implemented before this can be exploited.", new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null, "Pending", "Security vulnerability identified", "Issue with Microsoft 365 Business Premium" },
                    { 78, "62f94fe7-0580-42df-969c-50d4165d63b9", 8, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance audit found that user data retention exceeds policy requirements. Need to implement automated data purging for accounts inactive over 2 years.", new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null, "Pending", "Compliance audit findings need addressing", "Issue with Salesforce CRM" },
                    { 79, "62f94fe7-0580-42df-969c-50d4165d63b9", 10, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Current infrastructure is end-of-life and no longer receiving security patches. Migration to new infrastructure required within 90 days.", new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 29, null, "Pending", "Migration to new infrastructure required", "Issue with Managed IT Services" },
                    { 80, "62f94fe7-0580-42df-969c-50d4165d63b9", 7, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users are reporting that they cannot log in after the latest deployment. The login page loads but credentials are not being accepted. This is affecting approximately 30% of users.", null, 2, 4, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "Unable to access application after recent update", "Issue with Salesforce CRM" },
                    { 81, "62f94fe7-0580-42df-969c-50d4165d63b9", 8, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The application response time has increased significantly during peak hours (9 AM - 12 PM). Average response time has gone from 200ms to 3 seconds. Database queries appear to be the bottleneck.", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 17, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved", "Performance degradation during peak hours", "Issue with Notion Team Plan" },
                    { 82, "62f94fe7-0580-42df-969c-50d4165d63b9", 10, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "After configuring the integration, the service returns a 403 Forbidden error. API credentials have been verified and are correct. The issue started after a network policy change.", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18, null, "Pending", "Integration with third-party service failing", "Issue with Asana Business" },
                    { 83, "62f94fe7-0580-42df-969c-50d4165d63b9", 17, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Users are being logged out every 10 minutes despite the session timeout being configured for 60 minutes. This is causing workflow interruptions and data loss.", new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 27, null, "In Progress", "Authentication tokens expiring prematurely", "Issue with Security Audit Service" },
                    { 84, "62f94fe7-0580-42df-969c-50d4165d63b9", 5, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data changes made in the primary system are not reflecting in the secondary system. The sync job logs show successful completion but data remains inconsistent.", new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 12, null, "In Progress", "Data synchronization issues between systems", "Issue with Zendesk Support Suite" },
                    { 85, "62f94fe7-0580-42df-969c-50d4165d63b9", 16, null, "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Several UI components including buttons, dropdowns, and modals are misaligned on mobile devices. The responsive design breakpoints may need adjustment.", new DateTime(2025, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 14, null, "Open", "UI elements not rendering correctly on mobile", "Issue with Atlassian Cloud" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);
        }
    }
}
