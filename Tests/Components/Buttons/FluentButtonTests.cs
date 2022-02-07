using System;
using Bunit;
using LiveAI.FastBlazor;
using LiveAI.FastBlazor.Components;
using NUnit.Framework;

namespace FastBlazor.Tests.Components.Buttons
{
    public class FluentButtonTests
    {
        [Test]
        public void FluentButton_Basic_AppearanceNeutral()
        {
            // Arrange
            using var ctx = new Bunit.TestContext();

            // Act
            var button = ctx.RenderComponent<FluentButton>();

            // Assert
            button.MarkupMatches(@"<fluent-button appearance=""neutral""></fluent-button>");
        }

        [Test]
        public void FluentButton_Basic_AppearanceStealth()
        {
            // Arrange
            using var ctx = new Bunit.TestContext();

            // Act
            var button = ctx.RenderComponent<FluentButton>(parameters =>
                                parameters.Add(p => p.Appearance, Appearance.Stealth)
                          );

            // Assert
            button.MarkupMatches(@"<fluent-button appearance=""stealth""></fluent-button>");
        }

        [Test]
        public void FluentButton_Basic_Width()
        {
            // Arrange
            using var ctx = new Bunit.TestContext();

            // Act
            var button = ctx.RenderComponent<FluentButton>(parameters =>
                                parameters.Add(p => p.Width, "100px")
                          );

            // Assert
            button.MarkupMatches(@"<fluent-button appearance=""neutral"" style=""width: 100px;""></fluent-button>");
        }
    }
}
