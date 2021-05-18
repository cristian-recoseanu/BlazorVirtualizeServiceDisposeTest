# BlazorVirtualizeServiceDisposeTest

Test project to reproduce the following:  
Virtualize component prevents scoped injected services from being disposed.

## Summary

The `VirtualizePage` renders multiple `TestComponent` components which depend on the scoped service `ScopedServiceTest`.

Using the `Virtualize` component to render them causes the scoped service to never be disposed when refreshing/closing the page.

Uncommenting the section using the `Virtualize` component and using a foreach works as indented. The scoped service is created and always disposed correctly.
