
# 4chan Scraper

This small utility allows you to scrape every piece of media available on a 4chan thread and was written a little differently compared to the other releases. This time, loaded with LINQ queries, lambda expressions, and littered with Asynchronous markers. Because of this, it requires framework 4.5 to run.

![Demo](http://orig01.deviantart.net/9dbd/f/2015/186/e/4/4demo_by_oduslabs-d900jvq.png)

## Features

- Retain original name or use server-issued ID
- Supports .webm, .swf, and .pdf with standard image media formats
- Automatically creates sub-folder for thread
- Heavy implementation of Asynchronous programming

## Credits

* [4chan API documentation](https://github.com/4chan/4chan-API)
* [PatPositron's JSON tutorial](http://positron.pw/blog/7) _just_ for me
* [Mr. Trvp](https://github.com/MrTrvp) for his HttpClient cleanup (severe screw-up meant his commit was lost)
