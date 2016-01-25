//
//  Foreplug.m
//  Foregroundr
//
//  Created by Stephen Lavelle on 25/01/2016.
//  Copyright © 2016 Stephen Lavelle. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <Cocoa/Cocoa.h>

void activateWindow() {
    [[NSApplication sharedApplication] activateIgnoringOtherApps:TRUE];
}
