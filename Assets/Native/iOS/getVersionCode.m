#import <Foundation/Foundation.h>

extern int getBundleVersion() {
    NSString* bundleVersion = [[[NSBundle mainBundle] infoDictionary] objectForKey:@"CFBundleVersion"];
    return [bundleVersion intValue];
}

extern char* getBundleVersionString() {
    NSString* bundleVersion = [[[NSBundle mainBundle] infoDictionary] objectForKey:@"CFBundleVersion"];
    return strdup([bundleVersion UTF8String]);
}
