# Answer

The purpose of using a media query is to be able to have styles for different devices, sizes and orientations, to provide a user experience that best suits the device used.

### Scenario 1

```css
@media (max-width: 600px) 
{
  .top_menu 
   {
    display: none;
   }
}
```

The scenario 1 provides an implementation that styles a page without .top_menu if the width of device is lower or equals 600px

### Scenario 2

```css
@media (min-width: 700px) and (orientation: landscape) { 
    
    #profile_picture: {
        width: 200px;
	}
}
```

The scenario 2 provides an implementation that styles a #profile_picture of user with 200px of width when orientation is landscape and min-width of device is 700px.


### Scenario 3

```css
@media only screen and (max-width: 768px) {
  .toggle-menu {
    display: block;
  }
}
```

The scenario 3 provides an implementation that enable .toggle-menu visible on mobile devices.