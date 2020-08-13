# Answer

According to the css definition below, the text Hello, world! will be shown in red, as the css respects the order of the rules, the rule by ID has more strength than the class and the attribute itself

### Sample with class and id, the red is respected.

```html
<html>
	<head>
		<style type="text/css">
			#red {
			  color: red;
			}
			.blue {
			  color: blue;
			}
			span {
			  color: green;
			}
		</style>
	</head>
	<body>
		<div class="blue">
		  <span id="red" class="blue">Hello, world!</span>
		</div>
	</body>
</html>
```