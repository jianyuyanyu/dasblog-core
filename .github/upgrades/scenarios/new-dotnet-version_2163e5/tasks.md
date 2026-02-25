# DasBlog Core .NET 10.0 Upgrade Tasks

## Overview

This document tracks the execution of the DasBlog Core project upgrade from .NET 8.0 to .NET 10.0. All 8 projects will be upgraded simultaneously in a single atomic operation, followed by comprehensive testing and CI/CD pipeline updates.

**Progress**: 0/3 tasks complete (0%) ![0%](https://progress-bar.xyz/0)

---

## Tasks

### [▶] TASK-001: Atomic framework and dependency upgrade across all projects
**References**: Plan §5 Detailed Execution Steps, Plan §6 Package Update Reference, Plan §8 Breaking Changes Catalog

- [▶] (1) Update TargetFramework to net10.0 in all 8 project files: newtelligence.DasBlog.Runtime, DasBlog.Core, DasBlog.Services, DasBlog.Managers, DasBlog.CLI, DasBlog.Web, DasBlog.Tests.UnitTests, DasBlog.Test.Integration
- [ ] (2) All project files updated to net10.0 (**Verify**)
- [ ] (3) Update NuGet packages per Plan §6: Microsoft.Extensions.Options (8.0.2→10.0.3 in Core/Services/CLI), Microsoft.Extensions.Configuration packages (8.0.x→10.0.3 in CLI), Microsoft.AspNetCore packages (8.0.x→10.0.3 in Web/Test.Integration), Microsoft.VisualStudio.Web.CodeGeneration.Design (8.0.6→10.0.2 in Web), Microsoft.ApplicationInsights.AspNetCore (2.22.0→3.0.0 in Web)
- [ ] (4) All package references updated (**Verify**)
- [ ] (5) Remove package Microsoft.AspNetCore.Mvc.Razor.Extensions 6.0.36 from DasBlog.Web (functionality included in framework reference)
- [ ] (6) Package removal complete (**Verify**)
- [ ] (7) Restore all dependencies across solution
- [ ] (8) All dependencies restored successfully (**Verify**)
- [ ] (9) Build entire solution and fix all compilation errors per Plan §8.1-§8.2 (focus: ConfigurationBinder.GetValue<T> calls in DasBlog.Services/DasBlogPathResolver.cs and DasBlog.Web/DasBlogServiceCollectionExtensions.cs; Configure<T> extension calls in DasBlog.CLI/Program.cs and DasBlog.Web; TimeSpan.From* method calls; IdentityDbContext and AddRazorRuntimeCompilation recompilation)
- [ ] (10) Solution builds with 0 errors (**Verify**)
- [ ] (11) Commit changes with message: "TASK-001: Upgrade all projects to .NET 10.0 with dependency updates"

---

### [ ] TASK-002: Execute test suites and validate upgrade
**References**: Plan §5 Phase 4, Plan §8.3 Behavioral Changes

- [ ] (1) Run tests in DasBlog.Tests.UnitTests project
- [ ] (2) Fix any test failures (reference Plan §8 for TimeSpan.From* and behavioral changes)
- [ ] (3) Run tests in DasBlog.Test.Integration project
- [ ] (4) Fix any test failures
- [ ] (5) Re-run all tests after fixes
- [ ] (6) All tests pass with 0 failures (**Verify**)
- [ ] (7) Commit test fixes with message: "TASK-002: Complete .NET 10.0 testing and validation"

---

### [ ] TASK-003: Update CI/CD pipeline configuration
**References**: Plan §9 CI/CD Pipeline Updates

- [ ] (1) Update azure-pipelines.yml: change version from 8.2 to 10.2 (line 13), update display name from "Installing .NET 8" to "Installing .NET 10" (line 17), change SDK version from '8.x' to '10.x' (line 20)
- [ ] (2) Pipeline configuration updated (**Verify**)
- [ ] (3) Commit changes with message: "TASK-003: Update CI/CD pipeline for .NET 10.0"

---
