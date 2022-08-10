#import <Foundation/Foundation.h>

extern int getBundleVersion() {
    NSString* bundleVersion = [[[NSBundle mainBundle] infoDictionary] objectForKey:@"CFBundleVersion"];
    return [bundleVersion intValue];
}